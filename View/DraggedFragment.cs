using System.Drawing;

namespace CourseProject.View
{
    class DraggedFragment
    {
        public Rectangle SourceRect;
        public Point Location;
        public Color CanvasColor;

        public DraggedFragment(Rectangle rectangle, Point location, Color color)
        {
            SourceRect = rectangle;
            Location = location;
            CanvasColor = color;
        }

        public Rectangle Rect
        {
            get { return new Rectangle(Location, SourceRect.Size); }
        }

        // Фиксация изменения выделения
        public void Fix(Image image)
        {
            using (var clone = (Image)image.Clone())
            using (var gr = Graphics.FromImage(image))
            {
                gr.SetClip(SourceRect);
                gr.Clear(CanvasColor);

                gr.SetClip(Rect);
                gr.DrawImage(clone, Location.X - SourceRect.X, Location.Y - SourceRect.Y);
            }
        }
    }
}
