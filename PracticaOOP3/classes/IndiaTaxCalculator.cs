using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP3.classes
{
    public class IndiaTaxCalculator : TaxCalculator
    {
        public override double Calculate(double tax, double deduction)
        {
            Console.WriteLine($"India {tax * deduction} Calculation");
            return tax * deduction; // Cálculo respectivo para India
            //Y así para cada país
        }
    }
}
