using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    struct Equation
    {
        double k;
        double b;

        public Equation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            double rez = -b / k;
            return $"Ответ: {rez}";
        }
    }
}
