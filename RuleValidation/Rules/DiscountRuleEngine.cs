using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleValidation.Rules
{
    public class DiscountRuleEngine
    {
        List<IDiscountRule> _rules = new();

        public DiscountRuleEngine(IEnumerable<IDiscountRule?> rules)
        {
            _rules.AddRange(rules);
        }

        public decimal GetDiscountPercentage(Customer customer)
        {
            return _rules.Aggregate(0m, (current, rule) => Math.Max(current, rule.GetDiscount(customer, current)));
        }
    }

}
