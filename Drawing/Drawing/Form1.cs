using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen pen;
        int currentShape = 0;
        List<Point> points = new List<Point>();
        Point mouse;
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(canvas.Width, canvas.Height);
            graphics = Graphics.FromImage(bmp);
            graphics.Clear(Color.White);
            pen = new Pen(colorDialog.Color);
            mouse = new Point();
        }

        private void pointB_Click(object sender, EventArgs e)
        {
            currentShape = 0;
        }

        private void lineB_Click(object sender, EventArgs e)
        {
            currentShape = 1;
        }

        private void rectangleB_Click(object sender, EventArgs e)
        {
            currentShape = 2;
        }

        private void triangleB_Click(object sender, EventArgs e)
        {
            currentShape = 3;
        }

        private void circleB_Click(object sender, EventArgs e)
        {
            currentShape = 4;
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            switch (currentShape)
            {
                case 0:
                    new Point(points[0].X, points[0].Y).Draw(graphics, pen);
                    points.Clear();
                    break;
                case 1:
                    if (points.Count == 2)
                    {
                        new Line(points[0], points[1]).Draw(graphics, pen);
                        points.Clear();
                    }
                    break;
                case 2:
                    if (points.Count == 4)
                    {
                        new Rectangle(points[0], points[1], points[2], points[3]).Draw(graphics, pen);
                        points.Clear();
                    }
                    break;
                case 3:
                    if (points.Count == 3)
                    {
                        new Triangle(points[0], points[1], points[2]).Draw(graphics, pen);
                        points.Clear();
                    }
                    break;
                case 4:
                    if (points.Count == 2)
                    {
                        int r = (int)Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2) + Math.Pow(points[0].Y - points[1].Y, 2));
                        new Circle(points[0], r).Draw(graphics, pen);
                        points.Clear();
                    }
                    break;
            }
            canvas.Image = bmp;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
        }

        private void colorB_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            pen.Color = colorDialog.Color;
        }


        private void clearB_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            points.Clear();
            canvas.Image = bmp;
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                canvas.Image.Save(saveDialog.FileName);               
            }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
