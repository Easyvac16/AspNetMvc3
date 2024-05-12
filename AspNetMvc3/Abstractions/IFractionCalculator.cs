using AspNetMvc3.Models;

namespace AspNetMvc3.Abstractions
{
    public interface IFractionsCalculator
    {
        public Fractions Add(Fractions fr1, Fractions fr2);
        public Fractions Substract(Fractions fr1, Fractions fr2);
        public Fractions Divide(Fractions fr1, Fractions fr2);
        public Fractions Multiply(Fractions fr1, Fractions fr2);
    }
}
