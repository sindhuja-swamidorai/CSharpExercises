// See https://aka.ms/new-console-template for more information
using Math;

Console.WriteLine("Hello, World!");

BasicMath math = new BasicMath();
MathOperation mathOp = new MathOperation(math.Add);

Console.WriteLine(mathOp(1, 2));

mathOp = new MathOperation(math.Subtract);

Console.WriteLine(mathOp(1, 2));

mathOp = new MathOperation(math.Multiply);

Console.WriteLine(mathOp(1, 2));

mathOp = new MathOperation(math.Divide);

Console.WriteLine(mathOp(1, 2));

delegate double MathOperation(double a, double b);

namespace Math
{
    class BasicMath
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }

    }
}
