using System;
using System.Threading.Channels;

namespace MagicYearCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please input your surname: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Please enter your annual salary: ");
            var annualSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your work start year: ");
            var workStartYear = Convert.ToInt32(Console.ReadLine());

            var person1 = new MagicYearCalculator( name, surname, annualSalary, workStartYear);

            PrintMagicDetails(person1);
        }

        static void PrintMagicDetails(MagicYearCalculator person)
        {
            Console.WriteLine("\nYour magic age details are:\n");
            Console.WriteLine($"Name: {person.GetFullName()}");
            Console.WriteLine($"Monthly Salary: {person.GetMonthlySalary()}");
            Console.WriteLine($"Magic Year: {person.GetMagicYear()}");
        }
    }
}