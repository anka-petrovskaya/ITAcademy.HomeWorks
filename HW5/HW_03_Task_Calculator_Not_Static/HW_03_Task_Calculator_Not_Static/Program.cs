using System;


namespace HW_03_Calularot_Attempt_2
{
    class Program
    {
        public void Main()
        {
            int number1, number2;
            Console.WriteLine("Enter the number 1");
            string num1Txt = Console.ReadLine();
            number1 = Convert.ToInt32(num1Txt);

            Console.WriteLine("Enter the number 2");
            string num2Txt = Console.ReadLine();
            number2 = Convert.ToInt32(num2Txt);

            Calculator calc = new Calculator();
            Console.WriteLine(calc.Sum(number1, number2));
            Console.WriteLine(calc.Odd(number1, number2));
            Console.WriteLine(calc.Mult(number1, number2));
            Console.WriteLine(calc.Div(number1, number2));
            Console.WriteLine(calc.RemDiv(number1, number2));
        }
    }
    class Calculator
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Odd(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Mult(int number1, int number2)
        {
            return number1 * number2;
        }
        public double Div(double number1, double number2)
        {
            return number1 / number2;
        }
        public double RemDiv(double number1, double number2)
        {
            return number1 % number2;
        }
    }
}
