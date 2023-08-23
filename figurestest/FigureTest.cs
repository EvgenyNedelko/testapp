using Xunit;
using System;

using Figures;

namespace Figurestest
{
    public class FigureTest
    {
        [Fact]
        public void WrongEllipseCreation()
        {
            Assert.Throws<ArgumentException>(() => { Ellipse el = new(-4, 5); });
        }

        [Fact]
        public void WrongEllipseCreation1()
        {
            Assert.Throws<ArgumentException>(() => { Ellipse el = new(4, -5); });
        }

        [Fact]
        public void WrongEllipseCreation2()
        {
            Assert.Throws<ArgumentException>(() => { Ellipse el = new(-4, -5); });
        }

        [Fact]
        public void WrongCircleCreation()
        {
            Assert.Throws<ArgumentException>(() => { Circle c = new(-5); });
        }

        [Fact]
        public void EllipseArea()
        {
            Ellipse el = new Ellipse(4, 5);
            Assert.Equal(el.CalculateArea(), 4 * 5 * MathF.PI);
        }

        [Fact]
        public void CircleArea()
        {
            Circle cl = new Circle(5);
            Assert.Equal(cl.CalculateArea(), 5 * 5 * MathF.PI);
        }

        [Fact]
        public void CalculateTriangleArea()
        {
            Triangle tri = new(5, 4, 3);
            
            Assert.Equal(6, tri.CalculateArea());
        }

        [Fact]
        public void CalculateTriangleArea1()
        {
            Triangle tri = new(15, 14, 11);

            Assert.Equal(73.48f, MathF.Round(tri.CalculateArea(), 2));
        }

        [Fact]
        public void CalculateTriangleArea2()
        {
            Triangle tri = new(7, 6, 3);

            Assert.Equal(8.94f, MathF.Round(tri.CalculateArea(), 2));
        }

        [Fact]
        public void CheckRightTriangle()
        {
            Triangle tri = new(5, 4, 3);

            IsRightTriangle cond = new IsRightTriangle();
            Assert.True(cond.CheckCondition(tri));
        }
        [Fact]
        public void CheckValidTriangle()
        {
            Assert.Throws<ArgumentException>(() => { Triangle tri = new(10, 3, 3); });
        }
    }
}
