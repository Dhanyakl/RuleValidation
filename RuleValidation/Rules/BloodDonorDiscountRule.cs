using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleValidation.Rules
{
    public class BloodDonorDiscountRule : IDiscountRule
    {
        public decimal GetDiscount(Customer customer, decimal discount)
        {
            decimal result = 0;

            if (customer.IsBloodDonor) result = .15m;

            return result;
        }
    }

}
