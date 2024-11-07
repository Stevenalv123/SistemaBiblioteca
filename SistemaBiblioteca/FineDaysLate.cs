using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public class FineDaysLate : Fine
    {
        public int DaysLate { get; set; }

        private static int counterFines = 1;
        public FineDaysLate(int daysLate, string iDFine, string iDLoan, decimal baseAmount, decimal totalFine) : base(iDFine, iDLoan, baseAmount, totalFine)
        {
            DaysLate = daysLate;
        }
        public override string ToString()
        {
            return $"RetrasoPorMulta {DaysLate}, IDMulta {IDFine}, IDPrestamo {IDLoan}, MontoBase {BaseAmount}, TotalMulta {TotalFine}";
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
