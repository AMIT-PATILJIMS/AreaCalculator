using AreaCalculator;
//using Xunit;

namespace AreaCalculatorTests
{
    public class UnitTest1
    {
        [Fact]
        public void RectangleAreaCalculate()
        {
            //Arrange
            var num1 = 2;
            var num2 = 3;
            int ActualArea = num1 * num2;

            //Act
            var Area = Program.Rectangle(num1, num2);

            //Assert
            Assert.Equal(ActualArea, Area);
        }

        [Fact]
        public void CircleAreaCalculate()
        {
            //Arrange
            var radius = 3;
            var ActualArea = 3.14 * radius * radius;

            //Act
            var Area = Program.Circle(radius);

            //Assert
            Assert.Equal(ActualArea, Area);
        }

        [Fact]
        public void SquareAreaCalculate()
        {
            //Arrange
            var side = 4;
            var ActualArea = side * side;

            //Act
            var Area = Program.Square(side);

            //Assert
            Assert.Equal(ActualArea, Area);
        }

        [Fact]
        public void TriangleAreaCalculate()
        {
            //Arrange
            var baseOfTriangle = 2;
            var height = 5;

            var ActualArea = (baseOfTriangle * height) / 2;

            //Act
            var Area = Program.Triangle(baseOfTriangle, height);

            //Assert
            Assert.Equal(ActualArea, Area);
        }
    }
}