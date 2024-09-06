using System;
using System.Runtime.InteropServices;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(0, 3, 4, 7)]
        [InlineData(-5, -2, 4, -3)]
        [InlineData(null, 8, 7, 15)]
        
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculatorPlus = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculatorPlus.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)] //Add test data <-------
        [InlineData(2, 5, -3)]
        [InlineData(3, null, 3)]
        
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculatorMinus = new Calculator();

            //Act
            var actual = calculatorMinus.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 4, 12)] //Add test data <-------
        [InlineData(1, 16, 16)]
        [InlineData(-4, 5, -20)]
        [InlineData(0, 36, 0)]
        [InlineData(null, 14, 0)]
        
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculatorTimes = new Calculator();

            //Act
            var actual = calculatorTimes.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)] //Add test data <-------
        [InlineData(12, 4, 3)]
        [InlineData(10, 4, 2.5)]
        [InlineData(null, 4, 0)]
        [InlineData(4, null, 0)]
        
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculatorDividedBy = new Calculator();

            //Act
            var actual = calculatorDividedBy.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
