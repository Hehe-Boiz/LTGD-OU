using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    internal class Shape
    {
        public ShapeType Type { get; set; }
        public Rectangle Bounds { get; set; }
        public Color Color { get; set; }

        public Shape(ShapeType type, Rectangle bounds, Color color)
        {
            Type = type;
            Bounds = bounds;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(Color))
            {
                switch (Type)
                {
                    case ShapeType.Rectangle:
                        g.FillRectangle(brush, Bounds);
                        break;

                    case ShapeType.Ellipse:
                        g.FillEllipse(brush, Bounds);
                        break;

                    case ShapeType.Triangle:
                        Point p1 = new Point(Bounds.Left + Bounds.Width / 2, Bounds.Top);
                        Point p2 = new Point(Bounds.Left, Bounds.Bottom);
                        Point p3 = new Point(Bounds.Right, Bounds.Bottom);
                        Point[] trianglePoints = { p1, p2, p3 };
                        g.FillPolygon(brush, trianglePoints);
                        break;
                }
            }
        }

    }
}
