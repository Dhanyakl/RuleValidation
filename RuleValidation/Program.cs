// See https://aka.ms/new-console-template for more information
using RuleValidation.Rules;
using RuleValidation;

var discountCalculator = new DiscountCalculator();
var result = discountCalculator.CalculateDiscountPercentage(new Customer()
{
    Name = "Test Client",
    IsBloodDonor = true,
    BirthDate = new DateTime(1985, 12, 08)
});

Console.WriteLine(result);