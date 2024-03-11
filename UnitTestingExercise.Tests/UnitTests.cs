using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 21, 5, 29)]
        [InlineData(4, 4, 4, 12)]
        //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Add(num1, num2, num3);
            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 6, 6)]
        [InlineData(21, 10, 11)]
        [InlineData(100, 50, 50)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            var calc = new Calculator();

            //Act
            var actual = calc.Subtract(minuend, subtrhend);
            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 6, 36)]
        [InlineData(5, 4, 20)]
        [InlineData(10, 10, 100)]
        //Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(46, 2, 23)]
        [InlineData(10, 5, 2)]
        [InlineData(100, 25, 4)]
        //Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();
            //Act
            var actual = calc.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
