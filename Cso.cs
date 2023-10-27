using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cso : Henger
    {
        double falvastagsag;

        public Cso(double magassag, double sugar, double falvastagsag = 13) : base(magassag, sugar)
        {
            this.falvastagsag=falvastagsag;
        }
        public double Terfogat()
        {
            return Math.PI * GetMagassag * GetSugar;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
