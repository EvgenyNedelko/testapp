using Xunit;
using System;

using Figures;

namespace Figurestest
{
    public class FigureTest
    {
        [Fact]
        public void BasicEllipseTests()
        {
            IsValidEllipse cond = new();
            Ellipse el = new(4, 5);

            Assert.True(cond.CheckCondition(el));

            Assert.Equal(el.CalculateArea(), 4 * 5 * MathF.PI);

            Circle circle = new(5);

            Assert.True(cond.CheckCondition(circle));

            Assert.Equal(circle.CalculateArea(), 5 * 5 * MathF.PI);

            el = new(-4, 5);

            Assert.False(cond.CheckCondition(el));
         }

        [Fact]
        public void BasicPolygonTests()
        {
            IsValidTriangle condTriangle = new();
            IsRightTriangle condRightTriangle = new();

            Triangle tri = new(new Point(0, 0), new Point(5, 0), new Point(0, 5));

            Assert.True(condRightTriangle.CheckCondition(tri));

            Assert.Equal(12.5, tri.CalculateArea());

            tri = new(new Point(0, 0), new Point(1, 3), new Point(0, 4));

            Assert.False(condRightTriangle.CheckCondition(tri));
            Assert.Equal(2, tri.CalculateArea());
        }
    }
}
