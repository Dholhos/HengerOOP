using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TomorHenger : Henger
    {
       
            double fajsuly;

            public TomorHenger(double sugar, double magassag, double fajsuly) : base(magassag, sugar)
            {
                this.fajsuly = fajsuly;
            }
            public TomorHenger(double magassag, double sugar) : base(magassag, sugar)
            {
                this.fajsuly = 7.87;
            }
        public double GetFajsuly() => fajsuly;
        public double Suly() => fajsuly * Terfogat();
        public override string ToString() =>base.ToString()+$"fajsóly: {fajsuly}";
       
       
    }
}
