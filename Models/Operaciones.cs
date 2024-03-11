using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaAppMvvm.Models
{
    internal class Operaciones
    {
        public double Num1 { get; set; }

        public double Num2 { get; set; }

        public double TotalSuma() { 
            return Num1 + Num2;
        }

        public double TotalSuma(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
