using System;


namespace Calculator.Attemp2
{
    class Calculator
    {
        int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        int Odd(int number1, int number2)
        {
            return number1 - number2;
        }
        int Mult(int number1, int number2)
        {
            return number1 * number2;
        }
        double Div(double number1, double number2)
        {
            return number1 / number2;
        }
        double RemDiv(double number1, double number2)
        {
            return number1 % number2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Enter the number 1");
            string num1Txt = Console.ReadLine();
            number1 = Convert.ToInt32(num1Txt);

            Console.WriteLine("Enter the number 2");
            string num2Txt = Console.ReadLine();
            number2 = Convert.ToInt32(num2Txt);

            Calculator calc = new Calculator();
            calc.Sum(number1, number2);
            calc.Odd(number1, number2);
            calc.Mult(number1, number2);
            calc.Div(number1, number2);
            calc.RemDiv(number1, number2);
        }
    }
}
