using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    /// <summary>
    /// A Point object
    /// </summary>
    public class Point
    {
        /// <summary>
        /// The x coordinate of the point
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// The y coordinate of the point
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Create an undefined Point object
        /// </summary>
        public Point()
        {
        }
        /// <summary>
        /// Create a Point object using a coordinate pair
        /// </summary>
        /// <param name="x">The x coordinate of the point</param>
        /// <param name="y">The y coordinate of the point</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Draw the point
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="pen"></param>
        public void Draw(Graphics graphics, Pen pen)
        {
            //graphics.DrawLine(pen, X, Y, X + 1, Y + 1);
            graphics.DrawRectangle(pen, X, Y, 1, 1);
        }
    }
}
