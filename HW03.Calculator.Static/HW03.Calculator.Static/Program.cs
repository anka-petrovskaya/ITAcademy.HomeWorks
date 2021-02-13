using System;
using HW03.Calculator.Static;

namespace HW03.Calculator.Static
{
    static class Calculator
    {
        static public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        static public int Odd(int number1, int number2)
        {
            return number1 - number2;
        }
        static public int Mult(int number1, int number2)
        {
            return number1 * number2;
        }
        static public double Div(double number1, double number2)
        {
            return number1 / number2;
        }
        static public double RemDiv(double number1, double number2)
        {
            return number1 % number2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1");
            string num1Txt = Console.ReadLine();
            Console.WriteLine("Enter the number 2");
            string num2Txt = Console.ReadLine();
            int number1 = Convert.ToInt32(num1Txt);
            int number2 = int.Parse(num2Txt);
            Console.WriteLine(Calculator.Sum(number1, number2));
            Console.WriteLine(Calculator.Odd(number1, number2));
            Console.WriteLine(Calculator.Mult(number1, number2));
            Console.WriteLine(Calculator.Div(number1, number2));
            Console.WriteLine(Calculator.RemDiv(number1, number2));
        }
    }
}