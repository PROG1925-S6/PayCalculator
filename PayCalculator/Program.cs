using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string firstName;
            double hours;
            double payRate;
            double preTax;
            double taxRate = 0.25;
            double tax;
            double earned;
            
            //get inputs
            Console.Write("Please enter your name:");
            firstName = Console.ReadLine();

            Console.Write("Please enter hours worked:");
            hours = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your pay rate:");
            payRate = Convert.ToDouble(Console.ReadLine());

            //do stuff
            preTax = hours * payRate;
            tax = preTax * taxRate;
            earned = preTax - tax;

            //output answers
            Console.WriteLine($"Pay Calculation for {firstName}");
            Console.WriteLine($"pretax:         {preTax}");
            Console.WriteLine($"tax:            {tax.ToString("$.00")}");
            Console.WriteLine($"earned          {earned.ToString("C")}");

            Console.ReadKey();
        }
    }
}
