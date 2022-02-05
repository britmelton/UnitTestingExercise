using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        public int Add(int num1, int num2, int num3)
        {
            var sum = num1 + num2 + num3;
            return sum;
        }
        public int Subtract(int minuend, int subtrahend)
        {
            var difference = minuend - subtrahend;
            return difference;
        }
        public int Multiply(int num1, int num2)
        {
            var product = num1 * num2;
            return product;
        }
        public int Divide(int num1, int num2)
        {
            var quotient = num1 / num2;
            return quotient;
        }

    }
}
