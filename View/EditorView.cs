using CourseProject.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class EditorView : Form
    {
        // Стак для истории
        private readonly Stack<Bitmap> _history = new Stack<Bitmap>();

        // Фильтр для диалогов SaveFile и OpenFile 
        private const string _FILTER = "Изображения (*.bmp, *.png, *.jpg, *.jpeg)|*.bmp;*.png;*.jpg;*.jpeg;";

        // Позиция курсора на Canvas
        private int CanvasX;
        private int CanvasY;

        // Флаги для изменения размера холста
        private bool IsResizing = false;

        // Настройки инструмента
        private string SelectedTool;
        private int ToolWidth = 1;

        // Цветовая палитра
        public Color CanvasColor;
        public Color MainColor = Color.Black;
        public Color AdditionalColor = Color.White;

        // Флаги для управления рисованием
        public bool CtrlPressed;
        private bool CanPaint;
        private MouseButtons pressed_button;

        // Объекты для работы с изображением
        private Bitmap CanvasBitmap;
        private Bitmap TempBitmap;
        private DraggedFragment FragmentToDrag;

        // Положение курсора при рисовании
        private Point ToolStartPoint;
        private Point ToolFinishPoint;

        // Словарь инструмент-метод
        private Dictionary<string, Action<Graphics, Pen, Point, Point>> ToolActions;

        // Конструктор
        public EditorView(Color color)
        {
            InitializeComponent();

            CanvasColor = color;

            MainColorButton.ForeColor = MainColor;
            AdditionalColorButton.ForeColor = AdditionalColor;

            InitializeToolActions();

            DoubleBuffered = true;
            CanPaint = false;

            CanvasBitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Canvas.Image = CanvasBitmap;

            using (Graphics g = Graphics.FromImage(CanvasBitmap))
            {
                g.Clear(CanvasColor);
            }
        }

        // Конструктор
        public EditorView(Bitmap image)
        {
            InitializeComponent();

            CanvasColor = Color.White;

            MainColorButton.ForeColor = MainColor;
            AdditionalColorButton.ForeColor = AdditionalColor;

            InitializeToolActions();

            DoubleBuffered = true;
            CanPaint = false;

            CanvasBitmap = new Bitmap(image);
            Canvas.Image = CanvasBitmap;
            Canvas.Size = new Size(image.Width, image.Height);
            Canvas.Image = CanvasBitmap;
        }

        // Метод для отмены изменений
        private void Undo()
        {
            if (_history.Count > 0)
            {
                // Извлекаем последнее состояние из стека
                Bitmap previous_state = _history.Pop();

                // Освобождаем текущий CanvasBitmap
                CanvasBitmap.Dispose();

                // Применяем предыдущее состояние
                CanvasBitmap = new Bitmap(previous_state);
                Canvas.Image = CanvasBitmap;
                Canvas.Refresh();
            }
            else
            {
                MessageBox.Show("Нет изменений для отмены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Метод для сохранения текущего состояния CanvasBitmap
        private void SaveState()
        {
            // Сохраняем текущее состояние CanvasBitmap в стек
            _history.Push(new Bitmap(CanvasBitmap));
        }

        // Инициализатор словаря сложных инструментов
        private void InitializeToolActions()
        {
            ToolActions = new Dictionary<string, Action<Graphics, Pen, Point, Point>>
            {
                { "Линия", (g, pen, start, end) => g.DrawLine(pen, start, end) },
                { "Квадрат", DrawRectangle },
                { "Эллипс", DrawEllipse }
            };
        }

        // Общий метод для вычисления размеров и координат фигуры
        private (int x, int y, int width, int height) CalculateShapeDimensions(Point start, Point end, bool isCtrlPressed)
        {
            // Вычисляем разницу по осям X и Y
            int deltaX = end.X - start.X;
            int deltaY = end.Y - start.Y;

            // Если нажат Ctrl, делаем фигуру квадратной или круглой
            if (isCtrlPressed)
            {
                int size = Math.Max(Math.Abs(deltaX), Math.Abs(deltaY));

                // Сохраняем направление
                deltaX = Math.Sign(deltaX) * size;
                deltaY = Math.Sign(deltaY) * size;
            }

            // Определяем начальные координаты для рисования
            int x = deltaX < 0 ? start.X + deltaX : start.X;
            int y = deltaY < 0 ? start.Y + deltaY : start.Y;

            // Возвращаем координаты и размеры
            return (x, y, Math.Abs(deltaX), Math.Abs(deltaY));
        }

        // Нарисовать прямоугольник
        private void DrawRectangle(Graphics g, Pen pen, Point start, Point end)
        {
            bool isCtrlPressed = (ModifierKeys & Keys.Control) == Keys.Control;

            // Вычисляем размеры и координаты
            var (x, y, width, height) = CalculateShapeDimensions(start, end, isCtrlPressed);

            // Рисуем прямоугольник (или квадрат, если нажат Ctrl)
            if (pressed_button == MouseButtons.Left)
                g.DrawRectangle(pen, x, y, width, height);
            else if (pressed_button == MouseButtons.Right)
                g.FillRectangle(new SolidBrush(MainColor), x, y, width, height);
        }

        // Нарисовать эллипс
        private void DrawEllipse(Graphics g, Pen pen, Point start, Point end)
        {
            bool isCtrlPressed = (ModifierKeys & Keys.Control) == Keys.Control;

            // Вычисляем размеры и координаты
            var (x, y, width, height) = CalculateShapeDimensions(start, end, isCtrlPressed);

            // Рисуем эллипс (или круг, если нажат Ctrl)
            if (pressed_button == MouseButtons.Left)
                g.DrawEllipse(pen, x, y, width, height);
            else if (pressed_button == MouseButtons.Right)
                g.FillEllipse(new SolidBrush(MainColor), x, y, width, height);
        }

        // При нажатии кнопки мыши на холсте
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            pressed_button = e.Button == MouseButtons.Left ? MouseButtons.Left : MouseButtons.Right;

            if (SelectedTool != null)
            {
                // Проверяем, находится ли курсор в правом нижнем углу PictureBox
                if (SelectedTool == "Холст")
                {
                    if (e.Location.X >= Canvas.Width - 10 && e.Location.Y >= Canvas.Height - 10)
                    {
                        IsResizing = true;
                        Cursor.Current = Cursors.SizeNWSE;
                        SizeLabel.Location = new Point(Canvas.Right, Canvas.Bottom);
                        SizeLabel.Visible = true;
                        ToolFinishPoint = e.Location;
                    }
                    return;
                }

                SaveState();

                CanPaint = SelectedTool != null;
                ToolStartPoint = e.Location;
                Cursor.Current = Cursors.Cross;

                if (FragmentToDrag != null && !FragmentToDrag.Rect.Contains(e.Location))
                {
                    FragmentToDrag = null;
                    Canvas.Invalidate();
                }

                TempBitmap = (Bitmap)CanvasBitmap.Clone();
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            CanvasX = e.X;
            CanvasY = e.Y;
            CoordinateXStripStatusLabel.Text = "X: " + CanvasX.ToString();
            CoordinateYStripStatusLabel.Text = "Y: " + CanvasY.ToString();

            if (IsResizing)
            {
                CalculateCanvasResizing(e);
                return;
            }

            if (!CanPaint || SelectedTool == "Пипетка" || SelectedTool == "Заливка") return;

            Color color = e.Button == MouseButtons.Left ? MainColor : AdditionalColor;
            Pen pen = CreatePenForTool(SelectedTool, color);

            if (SelectedTool == "Выделить")
            {
                HandleSelectionTool(e);
            }
            else if (ToolActions.ContainsKey(SelectedTool))
            {
                // Создаем временное изображение для предварительного просмотра
                if (TempBitmap == null)
                {
                    TempBitmap = (Bitmap)CanvasBitmap.Clone();
                }

                using (Graphics g = Graphics.FromImage(TempBitmap))
                {
                    // Очищаем временное изображение, чтобы не накладывать фигуры
                    g.DrawImage(CanvasBitmap, 0, 0);

                    // Рисуем фигуру на временном изображении
                    ToolActions[SelectedTool](g, pen, ToolStartPoint, e.Location);
                }

                // Отображаем временное изображение
                Canvas.Image = TempBitmap;
            }
            else
            {
                // Для простых инструментов (например, карандаш) рисуем напрямую на CanvasBitmap
                using (Graphics g = Graphics.FromImage(CanvasBitmap))
                {
                    g.DrawLine(pen, ToolStartPoint, e.Location);
                }
                ToolStartPoint = e.Location;
                Canvas.Image = CanvasBitmap; // Обновляем изображение
            }
            
            Canvas.Refresh();
        }

        // Выделение
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (SelectedTool == "Выделить")
            {
                if (FragmentToDrag != null)
                {
                    e.Graphics.SetClip(FragmentToDrag.SourceRect);
                    e.Graphics.Clear(Color.White);

                    e.Graphics.SetClip(FragmentToDrag.Rect);
                    e.Graphics.DrawImage(Canvas.Image, FragmentToDrag.Location.X - FragmentToDrag.SourceRect.X, FragmentToDrag.Location.Y - FragmentToDrag.SourceRect.Y);

                    e.Graphics.ResetClip();
                    ControlPaint.DrawFocusRectangle(e.Graphics, FragmentToDrag.Rect);
                }
                else if (ToolStartPoint != ToolFinishPoint)
                {
                    ControlPaint.DrawFocusRectangle(e.Graphics, GetRect(ToolStartPoint, ToolFinishPoint));
                }
            }
        }

        // При отпускании клавиши мыши на холсте
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            IsResizing = false;
            SizeLabel.Visible = false;

            if (SelectedTool == null) return;

            CanPaint = false;

            if (SelectedTool == "Пипетка")
            {
                HandleColorPicker(e);
            }
            else if (SelectedTool == "Заливка")
            {
                HandleFillTool(e);
            }
            else if (SelectedTool == "Выделить")
            {
                if (ToolStartPoint != ToolFinishPoint)
                {
                    var rect = GetRect(ToolStartPoint, ToolFinishPoint);
                    FragmentToDrag = new DraggedFragment(rect, rect.Location, CanvasColor);
                }
                else if (FragmentToDrag != null)
                {
                    FragmentToDrag.Fix(Canvas.Image);
                    FragmentToDrag = null;
                    ToolStartPoint = ToolFinishPoint = e.Location;
                }
                Canvas.Invalidate();
            }
            else if (ToolActions.ContainsKey(SelectedTool))
            {
                SaveState();

                using (Graphics g = Graphics.FromImage(CanvasBitmap))
                {
                    g.DrawImage(TempBitmap, 0, 0);
                }

                Canvas.Image = CanvasBitmap;

                if (TempBitmap != null)
                {
                    TempBitmap.Dispose();
                    TempBitmap = null;
                }
            }
        }

        // Создание Pen для инструмента
        private Pen CreatePenForTool(string tool, Color color)
        {
            Pen pen;

            switch (tool)
            {
                case "Карандаш":
                    pen = new Pen(color, ToolWidth)
                    {
                        EndCap = LineCap.Square,
                        StartCap = LineCap.SquareAnchor
                    };
                    break;
                case "Кисть":
                    pen = new Pen(color, ToolWidth)
                    {
                        EndCap = LineCap.Round,
                        StartCap = LineCap.Round
                    };
                    break;
                case "Ластик":
                    pen = new Pen(CanvasColor, ToolWidth)
                    {
                        EndCap = LineCap.Square,
                        StartCap = LineCap.Round
                    };
                    break;
                default:
                    pen = new Pen(color, ToolWidth);
                    break;
            }

            return pen;
        }

        // Обработчик выделения
        private void HandleSelectionTool(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FragmentToDrag != null)
                {
                    FragmentToDrag.Location.Offset(e.Location.X - ToolFinishPoint.X, e.Location.Y - ToolFinishPoint.Y);
                    ToolStartPoint = e.Location;
                }
                ToolFinishPoint = e.Location;
                Canvas.Invalidate();
            }
            else
            {
                ToolStartPoint = ToolFinishPoint = e.Location;
            }
        }

        // Обработчик пипетки
        private void HandleColorPicker(MouseEventArgs e)
        {
            using (Bitmap image = new Bitmap(Canvas.Image))
            {
                Color color = image.GetPixel(e.X, e.Y);
                if (e.Button == MouseButtons.Left)
                {
                    MainColor = color;
                    MainColorButton.BackColor = color;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    AdditionalColor = color;
                    AdditionalColorButton.BackColor = color;
                }
                ColorDialog.Color = color;
            }
        }

        // Обработчик заливки
        private void HandleFillTool(MouseEventArgs e)
        {
            SaveState();

            Bitmap image = new Bitmap(Canvas.Image);

            Color old_color = image.GetPixel(e.X, e.Y);
            Color new_color = e.Button == MouseButtons.Left ? MainColor : AdditionalColor;

            if (old_color.ToArgb() == new_color.ToArgb()) return;

            if (e.X < 0 || e.X >= image.Width || e.Y < 0 || e.Y >= image.Height)
                return;

            BitmapData data = image.LockBits(
                new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb
            );

            int[] pixels = new int[image.Width * image.Height];
            Marshal.Copy(data.Scan0, pixels, 0, pixels.Length);

            int old_argb = old_color.ToArgb();
            int new_argb = new_color.ToArgb();

            Stack<Point> points = new Stack<Point>();
            points.Push(new Point(e.X, e.Y));

            while (points.Count > 0)
            {
                Point pt = points.Pop();

                if (pt.X < 0 || pt.X >= image.Width || pt.Y < 0 || pt.Y >= image.Height)
                    continue;

                int index = pt.Y * image.Width + pt.X;

                if (pixels[index] == old_argb)
                {
                    pixels[index] = new_argb;

                    points.Push(new Point(pt.X - 1, pt.Y));
                    points.Push(new Point(pt.X + 1, pt.Y));
                    points.Push(new Point(pt.X, pt.Y - 1));
                    points.Push(new Point(pt.X, pt.Y + 1));
                }
            }

            Marshal.Copy(pixels, 0, data.Scan0, pixels.Length);
            image.UnlockBits(data);

            Canvas.Image = image;
            CanvasBitmap = new Bitmap(image);
        }

        // Изменение толщины
        private void WidthTrackBar_ValueChanged(object sender, System.EventArgs e)
        {
            ToolWidth = WidthTrackBar.Value;
        }

        // Выбор инструмента
        private void ToolMenu_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton s = (RadioButton)sender;
            SelectedTool = s.Text;
        }

        // Основной цвет
        private void MainColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = MainColor;

            using (ColorDialog)
            {
                if (ColorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainColor = ColorDialog.Color;
                    MainColorButton.BackColor = ColorDialog.Color;
                }
            }
        }

        // Дополнительный цвет
        private void AdditionalColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = AdditionalColor;

            using (ColorDialog)
            {
                if (ColorDialog.ShowDialog() == DialogResult.OK)
                {
                    AdditionalColor = ColorDialog.Color;
                    AdditionalColorButton.BackColor = ColorDialog.Color;
                }
            }
        }

        // Высчитать прямоугольник
        private Rectangle GetRect(Point p1, Point p2)
        {
            var x1 = Math.Min(p1.X, p2.X);
            var x2 = Math.Max(p1.X, p2.X);
            var y1 = Math.Min(p1.Y, p2.Y);
            var y2 = Math.Max(p1.Y, p2.Y);
            return new Rectangle(x1, y1, x2 - x1, y2 - y1);
        }

        // Перерисовка холста без потери изображения
        private void Canvas_SizeChanged(object sender, EventArgs e)
        {
            // Получаем оригинальное изображение
            Bitmap original_bitmap = new Bitmap(Canvas.Image);

            // Создаем новый Bitmap с заданным размером
            Bitmap new_bitmap = new Bitmap(Canvas.Width, Canvas.Height, PixelFormat.Format32bppArgb);

            // Блокируем биты оригинального изображения
            BitmapData original_data = original_bitmap.LockBits(
                new Rectangle(0, 0, original_bitmap.Width, original_bitmap.Height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb
            );

            // Блокируем биты нового изображения
            BitmapData new_data = new_bitmap.LockBits(
                new Rectangle(0, 0, new_bitmap.Width, new_bitmap.Height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb
            );

            try
            {
                // Получаем указатели на данные
                IntPtr originalPtr = original_data.Scan0;
                IntPtr newPtr = new_data.Scan0;

                // Вычисляем количество байт для копирования
                int originalStride = original_data.Stride;
                int newStride = new_data.Stride;

                // Вычисляем минимальные размеры для копирования
                int copyWidth = Math.Min(original_bitmap.Width, new_bitmap.Width);
                int copyHeight = Math.Min(original_bitmap.Height, new_bitmap.Height);

                // Заливаем новый Bitmap цветом заполнения
                FillBitmap(newPtr, newStride, new_bitmap.Width, new_bitmap.Height, CanvasColor);

                // Копируем данные из оригинального изображения
                for (int y = 0; y < copyHeight; y++)
                {
                    IntPtr sourcePtr = IntPtr.Add(originalPtr, y * originalStride);
                    IntPtr destPtr = IntPtr.Add(newPtr, y * newStride);
                    byte[] buffer = new byte[copyWidth * 4];
                    Marshal.Copy(sourcePtr, buffer, 0, buffer.Length);
                    Marshal.Copy(buffer, 0, destPtr, buffer.Length);
                }
            }
            finally
            {
                original_bitmap.UnlockBits(original_data);
                new_bitmap.UnlockBits(new_data);
            }

            CanvasBitmap = new Bitmap(new_bitmap);
            Canvas.Image = new_bitmap;
        }

        // Заливка
        private void FillBitmap(IntPtr data, int stride, int width, int height, Color fillColor)
        {
            SaveState();

            // Создаем массив для хранения строки пикселей
            byte[] fill_row = new byte[width * 4]; // 4 байта на пиксель (ARGB)

            // Заполняем массив цветом
            for (int x = 0; x < width; x++)
            {
                fill_row[x * 4] = fillColor.B;
                fill_row[x * 4 + 1] = fillColor.G;
                fill_row[x * 4 + 2] = fillColor.R;
                fill_row[x * 4 + 3] = fillColor.A;
            }

            // Копируем заполненную строку в каждую строку изображения
            for (int y = 0; y < height; y++)
            {
                IntPtr destPtr = IntPtr.Add(data, y * stride);
                Marshal.Copy(fill_row, 0, destPtr, fill_row.Length);
            }
        }

        // Выделить все
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectRadioButton.Select();

            // Задаем начальную точку выделения (левый верхний угол Canvas)
            ToolStartPoint = new Point(0, 0);

            // Задаем конечную точку выделения (правый нижний угол Canvas)
            ToolFinishPoint = new Point(Canvas.Width, Canvas.Height);

            // Создаем прямоугольник выделения, охватывающий весь Canvas
            var rect = GetRect(ToolStartPoint, ToolFinishPoint);

            // Устанавливаем выделенный фрагмент
            FragmentToDrag = new DraggedFragment(rect, rect.Location, CanvasColor);

            // Обновляем Canvas, чтобы отобразить выделение
            Canvas.Invalidate();
        }

        // Вставить фрагмент
        private void PasteFragment()
        {
            SaveState();

            if (Clipboard.ContainsImage())
            {
                Image PastedImage = Clipboard.GetImage();
                using (Graphics g = Graphics.FromImage(CanvasBitmap))
                {
                    g.DrawImage(PastedImage, new Point(CanvasX, CanvasY)); // Укажите нужные координаты для вставки
                }
                Canvas.Image = CanvasBitmap;
            }
        }

        // Метод для копирования выделенного фрагмента в буфер обмена
        private void CopyFragment()
        {
            if (FragmentToDrag != null)
            {
                // Создаем Bitmap из выделенного фрагмента
                Bitmap fragmentBitmap = new Bitmap(FragmentToDrag.SourceRect.Width, FragmentToDrag.SourceRect.Height);
                using (Graphics g = Graphics.FromImage(fragmentBitmap))
                {
                    g.DrawImage(CanvasBitmap, new Rectangle(0, 0, fragmentBitmap.Width, fragmentBitmap.Height),
                                FragmentToDrag.SourceRect, GraphicsUnit.Pixel);
                }

                // Копируем Bitmap в буфер обмена
                Clipboard.SetImage(fragmentBitmap);
            }
        }

        // Метод для вырезания выделенного фрагмента
        private void CutFragment()
        {
            SaveState();

            if (FragmentToDrag != null)
            {
                // Копируем фрагмент в буфер обмена
                CopyFragment();
                DeleteFragment();
            }
        }

        // Удалить фрагмент с холста
        private void DeleteFragment()
        {
            SaveState();

            if (FragmentToDrag != null)
            {
                // Удаляем фрагмент с холста
                using (Graphics g = Graphics.FromImage(CanvasBitmap))
                {
                    g.SetClip(FragmentToDrag.SourceRect);
                    g.Clear(CanvasColor);
                }
            }

            // Обновляем изображение в PictureBox
            Canvas.Image = CanvasBitmap;

            // Сбрасываем выделение
            FragmentToDrag = null;
            Canvas.Invalidate();
        }

        // Открыть
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog)
                {
                    OpenFileDialog.Filter = _FILTER;

                    if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        UpdateCanvas(new Bitmap(OpenFileDialog.FileName, true));
                        RefreshFormName(OpenFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message + "\n" + ex.StackTrace);
            }
        }

        // Метод обновления картинки
        public void UpdateCanvas(Bitmap image)
        {
            try
            {
                // Освобождаем старое изображение
                Canvas.Image?.Dispose();

                // Проверяем размер изображения
                int newWidth = image.Width;
                int newHeight = image.Height;

                // Ограничиваем размер Canvas максимальными значениями (1700x800)
                if (newWidth > ClientSize.Width - 10 || newHeight > ClientSize.Height - 50)
                {
                    double widthRatio = 1700.0 / newWidth;
                    double heightRatio = 800.0 / newHeight;
                    double ratio = Math.Min(widthRatio, heightRatio);

                    newWidth = (int)(newWidth * ratio);
                    newHeight = (int)(newHeight * ratio);
                }

                CanvasBitmap = image;
                Canvas.Image = CanvasBitmap;
                Canvas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Сохранить
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog)
                {
                    SaveFileDialog.FileName = "Рисунок.jpg";
                    SaveFileDialog.Filter = _FILTER;

                    if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap bitmap = new Bitmap(Canvas.Image);
                        bitmap.Save(SaveFileDialog.FileName);

                        MessageBox.Show($"Файл сохранен в {SaveFileDialog.FileName}",
                            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message + "\n" + ex.StackTrace);
            }
        }

        // Служебный метод вывода ошибки
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(
                message, "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        // Расчет изменения размера холста
        private void CalculateCanvasResizing(MouseEventArgs e)
        {
            // Вычисляем новую ширину и высоту Canvas
            int newWidth = Canvas.Width + (e.X - ToolFinishPoint.X);
            int newHeight = Canvas.Height + (e.Y - ToolFinishPoint.Y);

            // Ограничиваем размеры Canvas, чтобы он не выходил за пределы формы
            int maxWidth = ClientSize.Width - 10 - Canvas.Left; // Максимальная ширина
            int maxHeight = ClientSize.Height - 25 - Canvas.Top; // Максимальная высота

            // Проверяем, чтобы новые размеры не превышали допустимые
            if (newWidth > maxWidth)
                newWidth = maxWidth;
            if (newHeight > maxHeight)
                newHeight = maxHeight;

            // Устанавливаем минимальные размеры (например, 50x50)
            int minWidth = 1;
            int minHeight = 1;

            if (newWidth < minWidth)
                newWidth = minWidth;
            if (newHeight < minHeight)
                newHeight = minHeight;

            // Убедимся, что Canvas не выходит за пределы формы
            // Проверяем, не выходит ли правая граница Canvas за пределы формы
            if (Canvas.Left + newWidth > ClientSize.Width)
                newWidth = ClientSize.Width - Canvas.Left;

            // Проверяем, не выходит ли нижняя граница Canvas за пределы формы
            if (Canvas.Top + newHeight > ClientSize.Height)
                newHeight = ClientSize.Height - Canvas.Top;

            // Устанавливаем новые размеры Canvas
            Canvas.Size = new Size(newWidth, newHeight);

            // Обновляем положение Label
            SizeLabel.Location = new Point(Canvas.Right, Canvas.Bottom);
            SizeLabel.Text = $"Ширина: {Canvas.Width}\nВысота: {Canvas.Height}";

            //this.Width - e.X < 200 ? e.Location : new Point(Width - e.X, e.Y)
            ToolFinishPoint = e.Location;
        }

        // Служебный метод переименования формы
        private void RefreshFormName(string filename)
        {
            Text = "Редактор - " + filename;
        }

        // Откат
        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyFragment();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutFragment();
        }
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteFragment();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFragment();
        }
    }
}