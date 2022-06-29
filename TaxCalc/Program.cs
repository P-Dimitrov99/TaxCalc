using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalc
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            IncomeTax incTax = new IncomeTax();
            Console.WriteLine("Input salary: ");
            double salary = double.Parse(Console.ReadLine());
            if (incTax.CheckRequirements(salary))
            {
                incTax.CalculateTax(salary);
                
            }
        }
    }
}
