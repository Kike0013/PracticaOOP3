using PracticaOOP3.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator india = new IndiaTaxCalculator();
            india.Calculate(20, 25);

            Console.ReadKey();

            //Solución de esta actividad en classes\TaxCalculator.cs y classes\IndiaCalculator.cs
        }
    }
}
