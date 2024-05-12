using AspNetMvc3.Abstractions;
using AspNetMvc3.Calculation;
using AspNetMvc3.Models;

namespace AspNetMvc3.Services
{
    public class Fractionservice : IFractionservice
    {
        public bool Calculate(FractionsOperationViewModel model)
        {
            switch (model.Operation)
            {
                case "+":
                    model.Result = FractionCalculator.Add(model.Fractions1, model.Fractions2).ToString();
                    return true;
                case "-":
                    model.Result = FractionCalculator.Substract(model.Fractions1, model.Fractions2).ToString();
                    return true;
                case "*":
                    model.Result = FractionCalculator.Multiply(model.Fractions1, model.Fractions2).ToString();
                    return true;
                case "/":
                    model.Result = FractionCalculator.Divide(model.Fractions1, model.Fractions2).ToString();
                    return true;
                default:
                    model.Result = null;
                    return false;

            }
        }
    }
}
