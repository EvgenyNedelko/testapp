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
        public void CheckValidTriangle()
        {
            Triangle tri = new(3, 4, 5);
            
            Assert.Equal(12.5, tri.CalculateArea());

        }
    }
}
