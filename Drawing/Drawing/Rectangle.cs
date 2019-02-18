using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    /// <summary>
    /// A Rectangle object
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Top left point
        /// </summary>
        public Point A { get; set; } = new Point();

        /// <summary>
        /// The width of the rectangle
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// The height of the rectangle
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Create an undefined Rectangle object
        /// </summary>
        public Rectangle()
        {
        }
        /// <summary>
        /// Create a Rectangle object using 2 coordinate pairs
        /// </summary>
        /// <param name="x1">The x coordinate of the top left point</param>
        /// <param name="y1">The y coordinate of the top left point</param>
        /// <param name="x2">The x coordinate of the down right point</param>
        /// <param name="y2">The y coordinate of the down right point</param>
        public Rectangle(int x1, int y1, int x2, int y2)
        {
            A.X = x1;
            A.Y = y1;

            Width = x2 - A.X;
            Height = y2 - A.Y;
            Translate();
        }
        /// <summary>
        /// Create a Rectangle object using 2 Point objects
        /// </summary>
        /// <param name="p1">Top left point</param>
        /// <param name="p2">Down right point</param>
        public Rectangle(Point p1, Point p2)
        {
            A = p1;

            Width = p2.X - A.X;
            Height = p2.Y - A.Y;
            Translate();
        }
        /// <summary>
        /// Create a Rectangle object using the top left point and width and height values
        /// </summary>
        /// <param name="p1">The top left point</param>
        /// <param name="width">The width of the rectangle</param>
        /// <param name="height">The height of the rectangle</param>
        public Rectangle(Point p1, int width, int height)
        {
            A = p1;
            Width = width;
            Height = height;
            Translate();
        }
        private void Translate()
        {
            Width = Math.Abs(Width);
            A.X -= Width;
            Height = Math.Abs(Height);
            A.Y -= Height;
        }

        /// <summary>
        /// Draw the rectangle
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="pen"></param>
        public void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawRectangle(pen, A.X, A.Y, Width, Height);
        }
    }
}
