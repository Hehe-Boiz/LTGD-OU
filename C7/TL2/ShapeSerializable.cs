using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL2
{
    internal class ShapeSerializable
    {
        public ShapeType Type { get; set; }
        public Rectangle Bounds { get; set; }
        public int ColorArgb { get; set; }

        public ShapeSerializable() { }

        // Constructor chuyển từ đối tượng Shape
        public ShapeSerializable(Shape shape)
        {
            Type = shape.Type;
            Bounds = shape.Bounds;
            ColorArgb = shape.Color.ToArgb();
        }

        // Phương thức chuyển về đối tượng Shape gốc
        public Shape ToShape()
        {
            return new Shape(Type, Bounds, Color.FromArgb(ColorArgb));
        }
    }
}
