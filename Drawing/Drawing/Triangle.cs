using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    /// <summary>
    /// A Triangle object
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// The first point of the triangle
        /// </summary>
        public Point A { get; set; } = new Point();
        /// <summary>
        /// The second point of the triangle
        /// </summary>
        public Point B { get; set; } = new Point();
        /// <summary>
        /// The third point of the triangle
        /// </summary>
        public Point C { get; set; } = new Point();

        /// <summary>
        /// Create an undefined Triangle object
        /// </summary>
        public Triangle()
        {
        }
        /// <summary>
        /// Create a Triangle object using 3 coordinate pairs
        /// </summary>
        /// <param name="x1">The x coordinate of the first point</param>
        /// <param name="y1">The y coordinate of the first point</param>
        /// <param name="x2">The x coordinate of the second point</param>
        /// <param name="y2">The y coordinate of the second point</param>
        /// <param name="x3">The x coordinate of the third point</param>
        /// <param name="y3">The y coordinate of the third point</param>
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            A.X = x1;
            A.Y = y1;

            B.X = x2;
            B.Y = y2;

            C.X = x3;
            C.Y = y3;
        }
        /// <summary>
        /// Create a Triangle object using 3 Point objects
        /// </summary>
        /// <param name="p1">The first point</param>
        /// <param name="p2">The second point</param>
        /// <param name="p3">The third point</param>
        public Triangle(Point p1, Point p2, Point p3)
        {
            A = p1;
            B = p2;
            C = p3;
        }

        /// <summary>
        /// Draw the triangle
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="pen"></param>
        public void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, A.X, A.Y, B.X, B.Y);
            graphics.DrawLine(pen, B.X, B.Y, C.X, C.Y);
            graphics.DrawLine(pen, C.X, C.Y, A.X, A.Y);
        }
    }
}
