using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
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

            if (k == 0 && b == 0)
                 return "Решение - любое число"; 
            return k == 0 ? "Решений нет" : $"Решение - {-b / k}";
        }
    }
}
