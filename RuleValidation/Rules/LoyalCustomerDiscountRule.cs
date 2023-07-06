using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleValidation.Rules
{
    public class LoyalCustomerDiscountRule : IDiscountRule
    {
        public decimal GetDiscount(Customer customer, decimal discount)
        {
            decimal result = 0;

            if (customer.ClientSince == null) result = 0;
            else if (customer.ClientSince.Value < DateTime.Now.AddYears(-10)) result = .1m;
            else if (customer.ClientSince.Value < DateTime.Now.AddYears(-5)) result = .05m;

            return result;
        }
    }

}
