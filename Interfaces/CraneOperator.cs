using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class CraneOperator : Employee
    {
        public decimal GetDangerPay()
        {
            return 0.04m; // Assuming danger pay is 4% of the annual salary
        }

        public override decimal AnnualSalary 
        {
            get { 
                return base.AnnualSalary + (base.AnnualSalary * GetDangerPay());
            }
        }
    }
}
