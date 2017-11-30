using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class CountingSum
    {
        public double x, E;
        

        public CountingSum(double x, double E)
        {
            this.x = x;
            this.E = E;
            
        }
     
        public double CountSumDirectly()
        {
            double sum = 1;
            double LastTerm = 1;
            int i = 1;
            while (Math.Abs(LastTerm) > E)
            {
                LastTerm *= -1.0 * Math.Pow(x, 2) / ((2 * i) * (2 * i - 1));
                sum += LastTerm;
                i++;
            }

            return sum;
        }

        public double CountSumAproximatly(double E,out int N)
        {
            double result = 1;
            double LastTerm = 1;
            N = 0;
            int i = 1;
            while (Math.Abs(LastTerm) > E)
            {

                    LastTerm *= -1 * Math.Pow(x, 2) / ((2 * i) * (2 * i - 1));

                    if (Math.Abs(LastTerm) > E)
                    {
                        result += LastTerm;
                        N++;
                    }
                i++;
            }
            return result;
        }
    }
}
