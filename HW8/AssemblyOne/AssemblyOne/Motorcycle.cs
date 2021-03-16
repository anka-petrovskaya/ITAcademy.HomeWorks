using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        public const ushort MaxSpeed = 300;
        public string vinNumber = "2sd34fdsd";
        public int odmeter = 20;
        public void StartEngine()
        {
        }

        internal const ushort MaxSpeedInternal = 301;
        internal string vinNumberInt = "2sd34fdsd";
        internal int odmeterInt = 20;
        internal void StartDate()
        {
        }

        protected const ushort MaxSpeedProtected = 301;
        protected string vinNumberPro = "2sd34fdsd";
        protected int odmeterPro = 20;
        protected void StartSpeed()
        {
        }

        private const ushort MaxSpeedPrivate = 301;
        private string vinNumberPrivate = "2sd34fdsd";
        private int odmeterPrivate = 20;
        private void odmeterPri()
        {
        }
    }
}