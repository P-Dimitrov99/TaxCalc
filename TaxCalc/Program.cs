//If we want to add new types of taxes to the solution
//all we need to do is create a new class for the new tax 
//create the methods for checking the requirements and calculating the tax
//and implement them in the same way as the other 2
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
            //we need to initialize an IncomeTax obj so we can use the methods
            IncomeTax incTax = new IncomeTax();
            //we read the input of the user
            Console.WriteLine("Input salary: ");
            double salary = double.Parse(Console.ReadLine());
            //we call CheckRequirements() 
            if (incTax.CheckRequirements(salary))
            {
                //if the return is true we call CalculateTax()
                incTax.CalculateTax(salary);
            }
            //if it is false we print the salary which was entered by the user
            else Console.WriteLine($"The net salary is: {salary}");
        }
    }
}
