using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    public class Ellipse : IFigure
    {
        private Point _origin;
        private float _radius1;
        private float _radius2;

        public Point Origin 
        {
            get { return _origin; }
            set { _origin = value; }
        }

        public float Radius1
        {
            get { return _radius1; }
            set { _radius1 = value; }
        }

        public float Radius2
        {
            get { return _radius2; }
            set { _radius2 = value; }
        }

        public Ellipse()
        {

        }

        public Ellipse(float radius1, float radius2)
        {
            this._radius1 = radius1;
            this._radius2 = radius2;
        }

        public Ellipse(Point origin, float radius1, float radius2) : this(radius1, radius2)
        {
            this._origin = origin;
        }

        public float CalculateArea() => _radius1 * _radius2 * MathF.PI;
    }

    public class Circle : Ellipse
    {
        public Circle(float radius) : base(radius, radius) { }

        public Circle(Point origin, float radius) : base(origin, radius, radius) { }
    }

    public class IsValidEllipse : IFigureCondition<Ellipse>
    {
        public bool CheckCondition(Ellipse figure)
        {
            if (figure.Radius1 < 0 || figure.Radius2 < 0)
                return false;
            else 
                return true;
        }
    }
}
