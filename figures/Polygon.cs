using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{    
    public class Polygon : IFigure
    {
        private List<Point> _points = new List<Point>();
        private Point _origin;

        public List<Point> Points
        {
            get { return _points; }
        }

        public Polygon()
        {

        }

        public Polygon(Point[] args)
        {
            _points.AddRange(args);
            SortPointsClockwise();
        }

        public void AddPoint(float x, float y)
        {
            _points.Add(new Point(x, y));
            SortPointsClockwise();
        }

        public Point CalculateCenterPoint()
        {
            return _points.Aggregate(new Point(0, 0), (acc, point) => { 
                acc.x += point.x / _points.Count;
                acc.y += point.y / _points.Count;
                return acc;
            });
        }

        public void SortPointsClockwise()
        {
            var center = CalculateCenterPoint();
            _points = _points.OrderBy(p => Math.Atan2(p.x - center.x, p.y - center.y)).ToList();
        }
            
        public float CalculateArea()
        {
            if (_points.Count > 2)
            {
                //shoelace algorithm
                int cnt = _points.Count;
                float area = 0;
                for (int i = 0; i < cnt - 1; i++)
                {
                    area += _points[i].x * _points[i + 1].y - _points[i + 1].x * _points[i].y;
                }
                return Math.Abs(area + _points[cnt - 1].x * _points[0].y - _points[0].x * _points[cnt - 1].y) / 2;
            }
            else return 0;
        }
    }
    public class Triangle : Polygon
    {
        public Triangle(Point x, Point y, Point z) : base(new[] { x, y, z }) { }
    }

    public class IsValidTriangle : IFigureCondition<Polygon>
    {
        public bool CheckCondition(Polygon figure)
        {
            if (figure.Points.Count == 3)
            {
                return true;
            }
            else
                return false;
        }
    }

    public class IsRightTriangle : IFigureCondition<Polygon>
    {
        public bool CheckCondition(Polygon figure)
        {
            var cond = new IsValidTriangle();
            if (cond.CheckCondition(figure))
            {
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
            else
                return false;
        }

        private float CalcAngle(Point p1, Point p2, Point center)
        {
            var cPoint1 = new Point(p1.x - center.x, p1.y - center.y);
            var cPoint2 = new Point(p2.x - center.x, p2.y - center.y);
            float norm1 = MathF.Sqrt(cPoint1.x * cPoint1.x + cPoint1.y * cPoint1.y);
            float norm2 = MathF.Sqrt(cPoint2.x * cPoint2.x + cPoint2.y * cPoint2.y);
          
            return MathF.Acos((cPoint1.x * cPoint2.x + cPoint1.y * cPoint2.y)  / ( norm1 * norm2)) * 180 / MathF.PI;
        }
    }
}
