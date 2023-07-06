using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleValidation
{
    public interface IDiscountRule
    {
        public decimal GetDiscount(Customer customer, decimal discount);
    }
}
