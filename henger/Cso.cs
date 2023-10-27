using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace henger
{
    public class Cso : Henger
    {
        double falVastagsag;

        public Cso(double magassag,double sugar, double falVastagsag = 1):base(magassag, sugar) 
        {
            this.falVastagsag=falVastagsag;
        }

        public override double Terfogat()
        {
            return Math.Round(Math.PI * GetMagassag * Math.Pow(GetSugar,2)- Math.PI * GetMagassag * Math.Pow((GetSugar-falVastagsag),2),2);
        }


        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Terfogat()}, sugár:{GetSugar}, magasság:{GetMagassag}, falvastagság {falVastagsag} ";
        }
    }
}
