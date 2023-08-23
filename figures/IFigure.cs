using System;

namespace Figures 
{
    public struct Point
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public interface IFigure
    {
        public float CalculateArea();
    }

    public interface IFigureCondition<T> where T : IFigure
    {
        public bool CheckCondition(T figure);
    }
}
