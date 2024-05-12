using AspNetMvc3.Models;

namespace AspNetMvc3.Calculation
{
    public class FractionCalculator
    {
        public static Fractions Add(Fractions a, Fractions b) =>
            new Fractions()
            {
                Numenator = a.Numenator * b.Denominator + b.Numenator * a.Denominator,
                Denominator = a.Denominator * b.Denominator,
            };

        public static Fractions Substract(Fractions a, Fractions b) =>
            new Fractions()
            {
                Numenator = a.Numenator * b.Denominator - b.Numenator * a.Denominator,
                Denominator = a.Denominator * b.Denominator,
            };

        public static Fractions Multiply(Fractions a, Fractions b) =>
            new Fractions()
            {
                Numenator = a.Numenator * b.Numenator,
                Denominator = b.Numenator * b.Denominator,
            };

        public static Fractions Divide(Fractions a, Fractions b) =>
            Multiply(a, new Fractions()
            {
                Numenator = b.Denominator,
                Denominator = b.Numenator,
            });
    }
}
