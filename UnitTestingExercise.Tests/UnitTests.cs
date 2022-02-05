using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(5, 10, 20, 35)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange        
            var sum = new Calculator();

            //Act         
            int actual = sum.Add(num1, num2, num3);

            //Assert             
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(-1, 2, -3)]
        [InlineData(10, 5, 5)]
        [InlineData(24, 8, 16)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var difference = new Calculator();

            //Act
            int actual = difference.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3,3,9)]
        [InlineData(9,3,27)]
        [InlineData(22,2,44)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Arrange
            var product = new Calculator();

            //Act
            int actual = product.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(24,6,4)]
        [InlineData(588, 2, 294)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var quotient = new Calculator();

            //Act
            int actual = quotient.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
