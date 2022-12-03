using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Converter
    {
        double usd, eur, zl;
        public Converter(double usd, double eur, double zl)
        {
            this.usd = usd;
            this.eur = eur;
            this.zl = zl;
        }

        public double FromGrn(double sum, string currency)
        {
            switch(currency.ToLower())
            {
                case "usd":
                    return sum / usd;
                case "eur":
                    return sum / eur;
                case "zl":
                    return sum / zl;                
                default: return 0;
            }
        }

        public double ToGrn(double sum, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return usd * sum;
                case "eur":
                    return eur * sum;
                case "zl":
                    return zl * sum;
                default: return 0;
            }
        }
    }
}
