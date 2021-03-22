using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.MinSpeed = 300;
            motorcycle.vinNumberInt = 898;
            motorcycle.StartEngine();

            motorcycle.odmeter = 89;

            motorcycle.odmeterInt = 20;
            motorcycle.StartDate(); 
            motorcycle.MaxSpeedInternal = 301;
            motorcycle.vinNumberInt = "2sd34fdsd";

            //motorcycle.MaxSpeedProtected = 7; protected level for all 4 lines
            //motorcycle.vinNumberPro = 8;
            //motorcycle.odmeterPro = 0b0;
            //motorcycle.StartSpeed();

            motorcycle.MaxSpeed = 300;
            motorcycle.vinNumber = "2sd34fdsd";
            motorcycle.odmeter = 20;
            motorcycle.StartEngine();

            //motorcycle.MaxSpeedPrivate = 301; private level
            //motorcycle.vinNumberPrivate = "2sd34fdsd";
            //motorcycle.odmeterPrivate = 20;
            //motorcycle.odmeterPri();
        }
    }
}