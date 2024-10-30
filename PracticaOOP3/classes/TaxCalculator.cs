using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP3.classes
{
    public abstract class TaxCalculator
    {
        /*
         * De esta manera se viola en principio open-closed porque cuando se requiera agregar
         * más países para hacer cálculos, habría que añadir un nuevo case por país, haciendo
         * necesaria la modificación de la clase cada vez.
         * 
         public decimal Calculate(decimal income, decimal deduction, string country)
         {
             decimal taxAmount = 0;
             decimal taxableIncome = income - deduction;

             switch (country)
             {
                 case "India":
                     //calculation here
                     break;
                 case "USA":
                     //calculation here
                     break;
                 case "UK":
                     //calculation here
                     break;
             }

             return taxAmount;
         }
        */

        public abstract double Calculate(double taxableIncome, double deduction); //convertimos la clase a abstracta
       // creamos métodos que hagan el cálculo basados en el país

    }
}
