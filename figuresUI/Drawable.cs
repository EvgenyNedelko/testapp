using Figures;
using System.Drawing;
using System.Linq;

namespace FiguresUI
{
    public class Drawable
    {
        private IFigure _figure;
        private string _name;

        public IFigure Figure
        {
            get { return _figure; }
        }

        public string Name
        {
            get { return _name; }
        }

        public Drawable(IFigure figure, string name)
        {
            _figure = figure;
            _name = name;
        }

        public void Draw(Graphics g, Pen pen)
        {
            if (_figure is Ellipse)
            {
                var el = _figure as Ellipse;
                g.DrawEllipse(pen, el.Origin.X - el.Radius1,
                                   el.Origin.Y - el.Radius2,
                                   el.Radius1 * 2,
                                   el.Radius2 * 2);
            }
            if (_figure is Polygon)
            {
                var pol = _figure as Polygon;
                var points = pol.Points.Select(p => new PointF(p.X, p.Y)).ToArray();
                if (points.Length > 2)
                {
                    g.DrawPolygon(pen, points);
                }
                else if (points.Length > 1)
                {
                    g.DrawLine(pen, points[0], points[1]);
                }
                foreach (var p in pol.Points)
                {
                    var rect = new Rectangle((int)(p.X - 1), (int)(p.Y - 1), 2, 2);
                    g.DrawRectangle(pen, rect);
                    g.FillRectangle(pen.Brush, rect);
                }
            }
        }
    }
}
