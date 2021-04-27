using System;

namespace MagicYearCalculator
{
    public class MagicYearCalculator
    {
        public MagicYearCalculator(string firstName, string surname, int annualSalary, int workStartYear)
        {
            FirstName = firstName;
            Surname = surname;
            AnnualSalary = annualSalary;
            WorkStartYear = workStartYear;
        }
        
        private string FirstName {get; set;}

        private string Surname {get; set;}
        
        private int AnnualSalary {get; set;}
        
        private int WorkStartYear{get; set;}
        
        public string GetFullName()
        {
            return $"{FirstName} {Surname}";
        }

        public int GetMonthlySalary()
        {
            return Convert.ToInt32(Math.Floor((double) (AnnualSalary / 12)));
        }

        public int GetMagicYear()
        {
            return WorkStartYear + 65;
        }
    }
}