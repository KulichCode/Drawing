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
        /// Top right point
        /// </summary>
        public Point B { get; set; } = new Point();
        /// <summary>
        /// Down right point
        /// </summary>
        public Point C { get; set; } = new Point();
        /// <summary>
        /// Down left point
        /// </summary>
        public Point D { get; set; } = new Point();
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
        /// Create a Rectangle object using 4 coordinate pairs
        /// </summary>
        /// <param name="x1">The x coordinate of the top left point</param>
        /// <param name="y1">The y coordinate of the top left point</param>
        /// <param name="x2">The x coordinate of the top right point</param>
        /// <param name="y2">The y coordinate of the top right point</param>
        /// <param name="x3">The x coordinate of the down right point</param>
        /// <param name="y3">The y coordinate of the down right point</param>
        /// <param name="x4">The x coordinate of the down left point</param>
        /// <param name="y4">The y coordinate of the down left point</param>
        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            A.X = x1;
            A.Y = y1;

            B.X = x2;
            B.Y = y2;

            Width = B.X - A.X;

            C.X = x3;
            C.Y = y3;

            D.X = x4;
            D.Y = y4;

            Height = D.Y - A.Y;
        }
        /// <summary>
        /// Create a Rectangle object using 4 Point objects
        /// </summary>
        /// <param name="p1">Top left point</param>
        /// <param name="p2">Top right point</param>
        /// <param name="p3">Down right point</param>
        /// <param name="p4">Down left point</param>
        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            A = p1;
            B = p2;
            C = p3;
            D = p4;

            Width = B.X - A.X;
            Height = D.Y - A.Y;
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
