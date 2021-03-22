using System;
using AssemblyOne;
namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyOne.Motorcycle moto = new AssemblyOne.Motorcycle();
        }
    }
    public class Moto
    {
        Motorcycle motorcycle = new Motorcycle();
        Motorcycle.MaxSpeedProtected = 7; 
        Motorcycle.vinNumberPro = 8;
        Motorcycle.odmeterPro = 0b0;
        Motorcycle.StartSpeed();
    }
}
