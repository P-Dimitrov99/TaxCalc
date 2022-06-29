using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalc
{
    public class SocialContribution
    {
        //here we check if the salary is lower than 3k
        public bool CheckRequirements(double sal)
        {
            if (sal <= 3000)
            {
                return true;
            }
            return false;
        }
        //here we do the calculations for the social contributions
        public double CalculateTax(double sal)
        { 
            sal -= sal * 0.15;
            Console.WriteLine($"The net salary is {sal + 1000}");
            return 1;
        }
    }
}
