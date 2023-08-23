using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Ellipse
    {
        public Circle(float radius) : base(radius, radius) { }

        public Circle(Point origin, float radius) : base(origin, radius, radius) { }
    }
}
