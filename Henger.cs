using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Henger
    {
        double magassag, sugar;
        static int zulatesSzamlalo;

        public Henger(double magassag, double sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            zulatesSzamlalo++;
        }

        public double GetMagassag { get => magassag;}
        public double GetSugar { get => sugar;}
        public static int ZulatesSzamlalo { get => zulatesSzamlalo;}

        public override string ToString() => $"jellemző >> térfogat:{Terfogat():N2}; sugár:{sugar}; magasság{magassag}";

        public double Terfogat()
        {
            return Math.Pow(sugar,2) * Math.PI * magassag;
        }
    }
}
