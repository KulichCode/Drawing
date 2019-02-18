using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    /// <summary>
    /// A Circle object
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// The centre of the circle
        /// </summary>
        public Point O { get; set; } = new Point();
        /// <summary>
        /// The radius of the circle
        /// </summary>
        public int R { get; set; }

        /// <summary>
        /// Create an undefined Circle object
        /// </summary>
        public Circle()
        {
        }
        /// <summary>
        /// Create a Circle object using a Point object an a radius
        /// </summary>
        /// <param name="o">The centre of the circle</param>
        /// <param name="r">The radius of the circle</param>
        public Circle(Point o, int r)
        {
            O = o;
            R = r;
        }
        /// <summary>
        /// Create a Circle object using a coordinate pair and a radius
        /// </summary>
        /// <param name="x">The x coordinate of the centre</param>
        /// <param name="y">The y coordinate of the centre</param>
        /// <param name="r">The radius of the circle</param>
        public Circle(int x, int y, int r)
        {
            O.X = x;
            O.Y = y;
            R = r;
        }
        /// <summary>
        /// Draw the circle
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="pen"></param>
        public void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen, O.X - R, O.Y - R, 2 * R, 2 * R);
        }
    }
}
