using System;
/*
namespace IPRF.Models
{
    public class CompleteTaxCalculous: SimpleTaxCalculous
    {
        private static double Calculous(User u)
        {
            double calculousBase = u.totalIncome;
            double dependentTaxDiscount = 0.0;
            if (u.getAge() < 65)
            {
                if ((u.numberDep > 0) && (u.numberDep <= 2))
                {
                    dependentTaxDiscount = 0.02;
                }
                else if ((u.numberDep > 2) && (u.numberDep <= 5))
                {
                    dependentTaxDiscount = 0.035;
                }
                else if (u.numberDep > 5)
                {
                    dependentTaxDiscount = 0.05;
                }
            }
            else
            {
                if ((u.numberDep > 0) && (u.numberDep <= 2))
                {
                    dependentTaxDiscount = 0.03;
                }
                else if ((u.numberDep > 2) && (u.numberDep <= 5))
                {
                    dependentTaxDiscount = 0.045;
                }
                else if (u.numberDep > 5)
                {
                    dependentTaxDiscount = 0.06;
                }
            }
            double dependentDiscount = calculousBase * dependentTaxDiscount;
            calculousBase = calculousBase - dependentDiscount;
            double finalTax;
            if (calculousBase <= 12000.0)
            {
                finalTax = 0;
            }
            else if ((calculousBase >= 12000.0) && (calculousBase < 24000.0))
            {
                finalTax = (calculousBase - 12000.0) * 0.15;
            }
            else
            {
                double tax1 = (23999.0 - 12000.0) * 0.15;
                double tax2 = (calculousBase - 23999.0) * 0.275;
                finalTax = tax1 + tax2;
            }
            return (finalTax);
        }
    }
}*/