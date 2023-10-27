using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace henger
{
    public class TomorHenger : Henger
    {
        double fajsuly;

        public TomorHenger(double magassag, double sugar, double fajsuly) : base(magassag, sugar)
        {
            this.fajsuly = fajsuly;
        }
        public TomorHenger(double magassag, double sugar) : base(magassag, sugar)
        {
            this.fajsuly = 7.87;
        }

        public double GetFajsuly {  get=>fajsuly;}
        public double Suly { get=>fajsuly;}

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Terfogat()}, sugár:{GetSugar}, magasság:{GetMagassag}, fajsúly {fajsuly} "; 
        }
    }
}
