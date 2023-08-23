using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Figures;
using Point = Figures.Point;

namespace FiguresUI
{
    public enum Mode
    {
        Ellipse,
        Polygon
    }

    public partial class frmMain : Form
    {
        private Mode? _mode;
        private BindingList<Drawable> _figures = new BindingList<Drawable>();
        private Drawable _current;
        private bool _mouseDown = false;
        private int _objectIndex = 1;

        public frmMain()
        {
            InitializeComponent();
            this.lstObjects.DataSource = _figures;
            this.lstObjects.DisplayMember = "Name";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Black);
            var selectedPen = new Pen(Color.Red);
            var selectedItem = lstObjects.SelectedItem;
            foreach(var d in _figures)
            {
                if (d == selectedItem)
                    d.Draw(e.Graphics, selectedPen);
                else
                    d.Draw(e.Graphics, pen);
            }
        }

        private void btnDeleteObject_Click(object sender, EventArgs e)
        {
            if (this.lstObjects.SelectedIndex > -1) {
                var d = this.lstObjects.SelectedItem as Drawable;
                this._figures.Remove(d);
                this.splitContainer1.Panel2.Invalidate();
                this.splitContainer1.Panel2.Update();
            }
        }

        private void lstObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstObjects.SelectedIndex > -1)
            {
                var d = (Drawable)this.lstObjects.SelectedItem;
                // convert from pixels to cm
                var area = d.Figure.CalculateArea() * 2.54 / ( Graphics.FromHwnd(this.Handle).DpiX * Graphics.FromHwnd(this.Handle).DpiY );
                this.txtArea.Text = area.ToString();
                
                this.splitContainer1.Panel2.Invalidate();
                this.splitContainer1.Panel2.Update();
            }
        }

        private void btnAddEllipse_Click(object sender, EventArgs e)
        {
            this._mode = Mode.Ellipse;
        }

        private void btnAddPolygon_Click(object sender, EventArgs e)
        {
            this._mode = Mode.Polygon;
            this._current = new Drawable(new Polygon(), "Polygon" + _objectIndex.ToString());
            this._figures.Add(_current);
            this._objectIndex++;
            this.lstObjects.SelectedItem = this._current;
        }

        private void splitContainer1_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (this._mode == Mode.Ellipse)
            {
                this._current = new Drawable(new Ellipse(new figures.Point(e.X, e.Y), 0, 0), "Ellipse" + _objectIndex.ToString());
                this._figures.Add(this._current);
                this._mouseDown = true;
                this._objectIndex++;
                this.lstObjects.SelectedItem = this._current;
            }
        }

        private void splitContainer1_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (this._mode == Mode.Ellipse)
            {
                this.UpdateEllipse(new PointF(e.X, e.Y));
            }
            this._mouseDown = false;
        }

        private void splitContainer1_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(this._mode == Mode.Ellipse && this._mouseDown)
            {
                this.UpdateEllipse(new PointF(e.X, e.Y));
            }
        }

        private void UpdateEllipse(PointF point)
        {
            var el = this._current.Figure as Ellipse;
            el.Radius1 = MathF.Abs(el.Origin.X - point.X);
            el.Radius2 = MathF.Abs(el.Origin.Y - point.Y);
            var area = el.CalculateArea() * 2.54 / (Graphics.FromHwnd(this.Handle).DpiX * Graphics.FromHwnd(this.Handle).DpiY);
            this.txtArea.Text = area.ToString();
            
            this.splitContainer1.Panel2.Invalidate();
            this.splitContainer1.Panel2.Update();
        }

        private void splitContainer1_Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (this._mode == Mode.Polygon)
            {
                var fig = this._current.Figure as Polygon;
                fig.AddPoint(e.X, e.Y);
                var area = fig.CalculateArea() * 2.54 / (Graphics.FromHwnd(this.Handle).DpiX * Graphics.FromHwnd(this.Handle).DpiY);
                this.txtArea.Text = area.ToString();
                
                this.splitContainer1.Panel2.Invalidate();
                this.splitContainer1.Panel2.Update();
            }
        }
    }
}
