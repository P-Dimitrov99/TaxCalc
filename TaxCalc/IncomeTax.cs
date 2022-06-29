using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalc
{
    //we create a class for the income tax.
    public class IncomeTax
    {
        SocialContribution socCont = new SocialContribution();
        //here we check if the salary is more than 1k
        public bool CheckRequirements(double sal)
        {
            if (sal > 1000)
            {
                return true;
            }
            return false;
        }
        //here we make the calculations for the income tax
        public double CalculateTax(double sal)
        {
            sal -= 1000;
            sal -= sal * 0.1;
            //we can use the methods from SocialContribution here because we are alredy checking if the salary is above 1k
            //we call the method CheckRequirements after we have already subtracted 1k + the income tax from the salary
            if (socCont.CheckRequirements(sal))
            {
                //we call the other method from SocialContribution to calculate and print the net salary 
                socCont.CalculateTax(sal);
            }
            //if CheckRequirements(sal) returns false we move here and simply print the the salary - 10% income tax 
            else Console.WriteLine($"The net salary is: {sal + 1000}");

            return 1;
        }
    }
}
