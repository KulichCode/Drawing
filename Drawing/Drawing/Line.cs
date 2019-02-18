using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    /// <summary>
    /// A Line object
    /// </summary>
    public class Line
    {
        /// <summary>
        /// The first point of the line
        /// </summary>
        public Point A { get; set; } = new Point();
        /// <summary>
        /// The seconf point of the line
        /// </summary>
        public Point B { get; set; } = new Point();

        /// <summary>
        /// Create an undefined Line object
        /// </summary>
        public Line()
        {
            
        }
        /// <summary>
        /// Create a Line object using 2 coordinate pairs
        /// </summary>
        /// <param name="x1">The x coordinate of the first point</param>
        /// <param name="y1">The y coordinate of the first point</param>
        /// <param name="x2">The x coordinate of the second point</param>
        /// <param name="y2">The y coordinate of the second point</param>
        public Line(int x1, int y1, int x2, int y2)
        {
            A.X = x1;
            A.Y = y1;
            B.X = x2;
            B.Y = y2;
        }
        /// <summary>
        /// Create a Line object using 2 Poing objects
        /// </summary>
        /// <param name="p1">The first point</param>
        /// <param name="p2">The second point</param>
        public Line(Point p1, Point p2)
        {
            A = p1;
            B = p2;
        }
        /// <summary>
        /// Draw the line
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="pen"></param>
        public void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, A.X, A.Y, B.X, B.Y);
        }
    }
}
