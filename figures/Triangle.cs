using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Polygon
    {
        public Triangle(Point x, Point y, Point z) : base(new[] { x, y, z }) { }

        public Triangle(float a, float b, float c)
        {
            if(a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Не верный треугольник");
            }

            this.AddPoint(0, 0);
            this.AddPoint(0, a);            
            // use cosine theorem to find angle between edges a and b
            float angle = MathF.Acos((a * a + b * b - c * c) / 2 * a * b);
            // we need to find a point on circle with radius b and angle 
            // x = b * cos(angle), y = b * sin(angle)
            this.AddPoint(b * MathF.Cos(angle), b * MathF.Sin(angle));
        }
    }

    public class IsValidTriangle : IFigureCondition<Polygon>
    {
        public bool CheckCondition(Polygon figure)
        {
            return figure.Points.Count == 3 && figure.CalculateArea() > 0;
        }
    }

    public class IsRightTriangle : IFigureCondition<Polygon>
    {
        public bool CheckCondition(Polygon figure)
        {
            var cond = new IsValidTriangle();
            if (!cond.CheckCondition(figure))
                return false;

            var angle1 = CalcAngle(figure.Points[0], figure.Points[1], figure.Points[2]);
            var angle2 = CalcAngle(figure.Points[0], figure.Points[2], figure.Points[1]);
            var angle3 = CalcAngle(figure.Points[2], figure.Points[1], figure.Points[0]);
            if (angle1 == 90 || angle2 == 90 || angle3 == 90)
            {
                return true;
            }
            else
                return false;
        }

        private float CalcAngle(Point p1, Point p2, Point center)
        {
            var cPoint1 = new Point(p1.X - center.X, p1.Y - center.Y);
            var cPoint2 = new Point(p2.X - center.X, p2.Y - center.Y);
            float norm1 = MathF.Sqrt(cPoint1.X * cPoint1.X + cPoint1.Y * cPoint1.Y);
            float norm2 = MathF.Sqrt(cPoint2.X * cPoint2.X + cPoint2.Y * cPoint2.Y);

            return MathF.Acos((cPoint1.X * cPoint2.X + cPoint1.Y * cPoint2.Y) / (norm1 * norm2)) * 180 / MathF.PI;
        }
    }
}
