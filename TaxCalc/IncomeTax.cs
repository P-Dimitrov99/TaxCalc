using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalc
{
    public class IncomeTax
    {
        SocialContribution socCont = new SocialContribution();
        public bool CheckRequirements(double sal)
        {
            if (sal - 1000 > 0)
            {
                return true;
            }
            return false;
        }
        public double CalculateTax(double sal)
        {
            sal -= 1000;
            sal -= sal * 0.1;
            if (socCont.CheckRequirements(sal))
            {
                socCont.CalculateTax(sal);
                Console.WriteLine($"The net salary is: {sal}");
            }
            Console.WriteLine($"The net salary is: {sal+1000}");
            return 1;
        }
    }
}
