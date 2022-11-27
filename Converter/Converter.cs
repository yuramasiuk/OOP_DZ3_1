using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        private double USD; //usd in 1 uah
        private double EUR; //eur in 1 uah
        public Converter(double usd, double eur)
        {
            USD = usd; EUR = eur;
        }

        public double UAHtoUSD(double uah)
        {
            return uah / USD;
        }
        public double UAHtoEUR(double uah)
        {
            return uah / EUR;
        }
        public double USDtoUAH(double usd)
        {
            return usd * USD;
        }
        public double EURtoUAH(double eur)
        {
            return eur * EUR;
        }
    }
}
