using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalc
{
    public class SocialContribution
    {
        public bool CheckRequirements(double sal)
        {
            if (sal <= 3000)
            {
                return true;
            }
            return false;
        }
        public double CalculateTax(double sal)
        {
           
            sal -= sal * 0.15;

            return sal;
        }
    }
}
