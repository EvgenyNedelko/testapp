using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{    
    public class Polygon : IFigure
    {
        private List<Point> _points = new List<Point>();

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
                acc.X += point.X / _points.Count;
                acc.Y += point.Y / _points.Count;
                return acc;
            });
        }

        public void SortPointsClockwise()
        {
            var center = CalculateCenterPoint();
            _points = _points.OrderBy(p => Math.Atan2(p.X - center.X, p.Y - center.Y)).ToList();
        }

        public float CalculateArea()
        {
            if (_points.Count < 3)
                return 0;

            //shoelace algorithm
            int cnt = _points.Count;
            float area = 0;
            for (int i = 0; i < cnt - 1; i++)
            {
                area += _points[i].X * _points[i + 1].Y - _points[i + 1].X * _points[i].Y;
            }
            return Math.Abs(area + _points[cnt - 1].X * _points[0].Y - _points[0].X * _points[cnt - 1].Y) / 2;
        }
    }
}
