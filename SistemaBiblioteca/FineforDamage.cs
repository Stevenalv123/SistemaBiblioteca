using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public class FineforDamage : Fine
    {
        

        public string DescriptionOfTheDamage {  get; set; }


        private static int counterFines = 1;

        public FineforDamage(string iDFine, string iDLoan, decimal baseAmount, decimal totalFine) : base(iDFine, iDLoan, baseAmount, totalFine)
        {
            DescriptionOfTheDamage = DescriptionOfTheDamage;

        }
        private string GenerateIdFine()
        {
            return $"M{counterFines.ToString("D3")}";

        }

        public static void IncrementCounter()
        {
            counterFines++;
        }
    }
}
