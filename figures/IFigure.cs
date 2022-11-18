using System;

namespace figures 
{
    public struct Point
    {
        public float x, y;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
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
