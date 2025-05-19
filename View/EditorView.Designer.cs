namespace CourseProject
{
    partial class EditorView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorView));
            this.WidthTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.AdditionalColorButton = new System.Windows.Forms.Button();
            this.MainColorButton = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.CoordinateXStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CoordinateYStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ResizeRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectRadioButton = new System.Windows.Forms.RadioButton();
            this.LineRadioButton = new System.Windows.Forms.RadioButton();
            this.CircleRadioButton = new System.Windows.Forms.RadioButton();
            this.SquareRadioButton = new System.Windows.Forms.RadioButton();
            this.DropperRadioButton = new System.Windows.Forms.RadioButton();
            this.EraserRadioButton = new System.Windows.Forms.RadioButton();
            this.BucketRadioButton = new System.Windows.Forms.RadioButton();
            this.BrushToolRadioButton = new System.Windows.Forms.RadioButton();
            this.PenToolRadioButton = new System.Windows.Forms.RadioButton();
            this.Canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // WidthTrackBar
            // 
            this.WidthTrackBar.Location = new System.Drawing.Point(851, 45);
            this.WidthTrackBar.Maximum = 100;
            this.WidthTrackBar.Minimum = 1;
            this.WidthTrackBar.Name = "WidthTrackBar";
            this.WidthTrackBar.Size = new System.Drawing.Size(154, 45);
            this.WidthTrackBar.TabIndex = 1;
            this.WidthTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.WidthTrackBar.Value = 1;
            this.WidthTrackBar.ValueChanged += new System.EventHandler(this.WidthTrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(902, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Толщина";
            // 
            // AdditionalColorButton
            // 
            this.AdditionalColorButton.BackColor = System.Drawing.Color.White;
            this.AdditionalColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.AdditionalColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdditionalColorButton.Location = new System.Drawing.Point(800, 30);
            this.AdditionalColorButton.Name = "AdditionalColorButton";
            this.AdditionalColorButton.Size = new System.Drawing.Size(45, 45);
            this.AdditionalColorButton.TabIndex = 11;
            this.AdditionalColorButton.UseVisualStyleBackColor = false;
            this.AdditionalColorButton.Click += new System.EventHandler(this.AdditionalColorButton_Click);
            // 
            // MainColorButton
            // 
            this.MainColorButton.BackColor = System.Drawing.Color.Black;
            this.MainColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.MainColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainColorButton.Location = new System.Drawing.Point(749, 30);
            this.MainColorButton.Name = "MainColorButton";
            this.MainColorButton.Size = new System.Drawing.Size(45, 45);
            this.MainColorButton.TabIndex = 12;
            this.MainColorButton.UseVisualStyleBackColor = false;
            this.MainColorButton.Click += new System.EventHandler(this.MainColorButton_Click);
            // 
            // ColorDialog
            // 
            this.ColorDialog.Color = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Цвет";
            // 
            // MenuStrip
            // 
            this.MenuStrip.AllowMerge = false;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.SelectToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1024, 24);
            this.MenuStrip.TabIndex = 15;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackToolStripMenuItem.Image = global::CourseProject.Properties.Resources.back;
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.BackToolStripMenuItem.ShowShortcutKeys = false;
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.BackToolStripMenuItem.Text = "Назад";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SelectToolStripMenuItem
            // 
            this.SelectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            this.SelectToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.SelectToolStripMenuItem.Text = "Выделение";
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.SelectAllToolStripMenuItem.Text = "Выделить все";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.PasteToolStripMenuItem.Text = "Вставить";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(935, 30);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(83, 13);
            this.SizeLabel.TabIndex = 16;
            this.SizeLabel.Text = "Размер холста";
            this.SizeLabel.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoordinateXStripStatusLabel,
            this.CoordinateYStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 598);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1024, 22);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // CoordinateXStripStatusLabel
            // 
            this.CoordinateXStripStatusLabel.Name = "CoordinateXStripStatusLabel";
            this.CoordinateXStripStatusLabel.Size = new System.Drawing.Size(17, 17);
            this.CoordinateXStripStatusLabel.Text = "X:";
            // 
            // CoordinateYStripStatusLabel
            // 
            this.CoordinateYStripStatusLabel.Name = "CoordinateYStripStatusLabel";
            this.CoordinateYStripStatusLabel.Size = new System.Drawing.Size(17, 17);
            this.CoordinateYStripStatusLabel.Text = "Y:";
            // 
            // ResizeRadioButton
            // 
            this.ResizeRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ResizeRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ResizeRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ResizeRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResizeRadioButton.FlatAppearance.BorderSize = 0;
            this.ResizeRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.ResizeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResizeRadioButton.Image = global::CourseProject.Properties.Resources.resize;
            this.ResizeRadioButton.Location = new System.Drawing.Point(604, 27);
            this.ResizeRadioButton.Name = "ResizeRadioButton";
            this.ResizeRadioButton.Size = new System.Drawing.Size(68, 68);
            this.ResizeRadioButton.TabIndex = 17;
            this.ResizeRadioButton.Text = "Холст";
            this.ResizeRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ResizeRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ResizeRadioButton.UseVisualStyleBackColor = false;
            this.ResizeRadioButton.CheckedChanged += new System.EventHandler(this.ToolMenu_CheckedChanged);
            // 
            // SelectRadioButton
            // 
            this.SelectRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SelectRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SelectRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectRadioButton.FlatAppearance.BorderSize = 0;
            this.SelectRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.SelectRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectRadioButton.Image = global::CourseProject.Properties.Resources.square_selection;
            this.SelectRadioButton.Location = new System.Drawing.Point(678, 27);
            this.SelectRadioButton.Name = "SelectRadioButton";
            this.SelectRadioButton.Size = new System.Drawing.Size(68, 68);
            this.SelectRadioButton.TabIndex = 14;
            this.SelectRadioButton.Text = "Выделить";
            this.SelectRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SelectRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SelectRadioButton.UseVisualStyleBackColor = false;
            this.SelectRadioButton.CheckedChanged += new System.EventHandler(this.ToolMenu_CheckedChanged);
            // 
            // LineRadioButton
            // 
            this.LineRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.LineRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LineRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LineRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LineRadioButton.FlatAppearance.BorderSize = 0;
            this.LineRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.LineRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineRadioButton.Image = global::CourseProject.Properties.Resources.line;
            this.LineRadioButton.Location = new System.Drawing.Point(382, 27);
            this.LineRadioButton.Name = "LineRadioButton";
            this.LineRadioButton.Size = new System.Drawing.Size(68, 68);
            this.LineRadioButton.TabIndex = 10;
            this.LineRadioButton.Text = "Линия";
            this.LineRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LineRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LineRadioButton.UseVisualStyleBackColor = false;
            this.LineRadioButton.CheckedChanged += new System.EventHandler(this.ToolMenu_CheckedChanged);
            // 
            // CircleRadioButton
            // 
            this.CircleRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.CircleRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.CircleRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CircleRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CircleRadioButton.FlatAppearance.BorderSize = 0;
            this.CircleRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.CircleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CircleRadioButton.Image = global::CourseProject.Properties.Resources.circle;
            this.CircleRadioButton.Location = new System.Drawing.Point(456, 27);
            this.CircleRadioButton.Name = "CircleRadioButton";
            this.CircleRadioButton.Size = new System.Drawing.Size(68, 68);
            this.CircleRadioButton.TabIndex = 9;
            this.CircleRadioButton.Text = "Эллипс";
            this.CircleRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CircleRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CircleRadioButton.UseVisualStyleBackColor = false;
            this.CircleRadioButton.CheckedChanged += new System.EventHandler(this.ToolMenu_CheckedChanged);
            // 
            // SquareRadioButton
            // 
            this.SquareRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SquareRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SquareRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SquareRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SquareRadioButton.FlatAppearance.BorderSize = 0;
            this.SquareRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.SquareRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquareRadioButton.Image = global::CourseProject.Properties.Resources.square;
            this.SquareRadioButton.Location = new System.Drawing.Point(530, 27);
            this.SquareRadioButton.Name = "SquareRadioButton";
            this.SquareRadioButton.Size = new System.Drawing.Size(68, 68);
            this.SquareRadioButton.TabIndex = 8;
            this.SquareRadioButton.Text = "Квадрат";
            this.SquareRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SquareRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SquareRadioButton.UseVisualStyleBackColor = false;
            this.SquareRadioButton.CheckedChanged += new System.EventHandler(this.ToolMenu_CheckedChanged);
            // 
            // DropperRadioButton
            // 
            this.DropperRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.DropperRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.DropperRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DropperRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DropperRadioButton.FlatAppearance.BorderSize = 0;
            this.DropperRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.DropperRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropperRadioButton.Image = global::CourseProject.Properties.Resources.dropper;
            this.DropperRadioButton.Location = new System.Drawing.Point(234, 27);
            this.DropperRadioButton.Name = "DropperRadioButton";
            this.DropperRadioButton.Size = new System.Drawing.Size(68, 68);
            this.DropperRadioButton.TabIndex = 7;
            this.DropperRadioButton.Text = "Пипетка";
            this.DropperRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DropperRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DropperRadioButton.UseVisualStyleBackColor = false;
            this.DropperRadioButton.CheckedChanged += new System.EventHandler(this.ToolMenu_CheckedChanged);
            // 
            // EraserRadioButton
            // 
            this.EraserRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.EraserRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.EraserRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EraserRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EraserRadioButton.FlatAppearance.BorderSize = 0;
            this.EraserRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.EraserRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EraserRadioButton.Image = global::CourseProject.Properties.Resources.eraser;
            this.EraserRadioButton.Location = new System.Drawing.Point(160, 27);
            this.EraserRadioButton.Name = "EraserRadioButton";
            this.EraserRadioButton.Size = new System.Drawing.Size(68, 68);
            this.EraserRadioButton.TabIndex = 6;
            this.EraserRadioButton.Text = "Ластик";
            this.EraserRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EraserRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EraserRadioButton.UseVisualStyleBackColor = false;
            this.EraserRadioButton.CheckedChanged += new System.EventHandler(this.ToolMenu_CheckedChanged);
            // 
            // BucketRadioButton
            // 
            this.BucketRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.BucketRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.BucketRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BucketRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BucketRadioButton.FlatAppearance.BorderSize = 0;
            this.BucketRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.BucketRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BucketRadioButton.Image = global::CourseProject.Properties.Resources.bucket;
            this.BucketRadioButton.Location = new System.Drawing.Point(308, 27);
            this.BucketRadioButton.Name = "BucketRadioButton";
            this.BucketRadioButton.Size = new System.Drawing.Size(68, 68);
            this.BucketRadioButton.TabIndex = 5;
            this.BucketRadioButton.Text = "Заливка";
            this.BucketRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BucketRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BucketRadioButton.UseVisualStyleBackColor = false;
            this.BucketRadioButton.CheckedChanged += new System.EventHandler(this.ToolMenu_CheckedChanged);
            // 
            // BrushToolRadioButton
            // 
            this.BrushToolRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.BrushToolRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.BrushToolRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BrushToolRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrushToolRadioButton.FlatAppearance.BorderSize = 0;
            this.BrushToolRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.BrushToolRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrushToolRadioButton.Image = global::CourseProject.Properties.Resources.brush;
            this.BrushToolRadioButton.Location = new System.Drawing.Point(86, 27);
            this.BrushToolRadioButton.Name = "BrushToolRadioButton";
            this.BrushToolRadioButton.Size = new System.Drawing.Size(68, 68);
            this.BrushToolRadioButton.TabIndex = 4;
            this.BrushToolRadioButton.Text = "Кисть";
            this.BrushToolRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BrushToolRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BrushToolRadioButton.UseVisualStyleBackColor = false;
            this.BrushToolRadioButton.CheckedChanged += new System.EventHandler(this.ToolMenu_CheckedChanged);
            // 
            // PenToolRadioButton
            // 
            this.PenToolRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.PenToolRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.PenToolRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PenToolRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PenToolRadioButton.FlatAppearance.BorderSize = 0;
            this.PenToolRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.PenToolRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PenToolRadioButton.Image = global::CourseProject.Properties.Resources.pencil;
            this.PenToolRadioButton.Location = new System.Drawing.Point(12, 27);
            this.PenToolRadioButton.Name = "PenToolRadioButton";
            this.PenToolRadioButton.Size = new System.Drawing.Size(68, 68);
            this.PenToolRadioButton.TabIndex = 3;
            this.PenToolRadioButton.Text = "Карандаш";
            this.PenToolRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PenToolRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PenToolRadioButton.UseVisualStyleBackColor = false;
            this.PenToolRadioButton.CheckedChanged += new System.EventHandler(this.ToolMenu_CheckedChanged);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Location = new System.Drawing.Point(0, 98);
            this.Canvas.Margin = new System.Windows.Forms.Padding(0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(716, 411);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.SizeChanged += new System.EventHandler(this.Canvas_SizeChanged);
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // EditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 620);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ResizeRadioButton);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.SelectRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MainColorButton);
            this.Controls.Add(this.AdditionalColorButton);
            this.Controls.Add(this.LineRadioButton);
            this.Controls.Add(this.CircleRadioButton);
            this.Controls.Add(this.SquareRadioButton);
            this.Controls.Add(this.DropperRadioButton);
            this.Controls.Add(this.EraserRadioButton);
            this.Controls.Add(this.BucketRadioButton);
            this.Controls.Add(this.BrushToolRadioButton);
            this.Controls.Add(this.PenToolRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WidthTrackBar);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(1040, 300);
            this.Name = "EditorView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Редактор";
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.TrackBar WidthTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton PenToolRadioButton;
        private System.Windows.Forms.RadioButton BrushToolRadioButton;
        private System.Windows.Forms.RadioButton BucketRadioButton;
        private System.Windows.Forms.RadioButton EraserRadioButton;
        private System.Windows.Forms.RadioButton DropperRadioButton;
        private System.Windows.Forms.RadioButton SquareRadioButton;
        private System.Windows.Forms.RadioButton CircleRadioButton;
        private System.Windows.Forms.RadioButton LineRadioButton;
        private System.Windows.Forms.Button AdditionalColorButton;
        private System.Windows.Forms.Button MainColorButton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton SelectRadioButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.RadioButton ResizeRadioButton;
        private System.Windows.Forms.ToolStripMenuItem SelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CoordinateXStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel CoordinateYStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
    }
}

