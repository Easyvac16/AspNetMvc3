namespace AspNetMvc3.Models
{
    public class Fractions
    {
        public int Numenator { get; set; }
        public int Denominator { get; set; }

        public string ToDecimalString() => ((double)(Numenator) / Denominator).ToString("0.##");

        public override string ToString() => $"{Numenator}/{Denominator}";
        public Fractions() { }
        public Fractions(int n, int d) { Numenator = n; Denominator = d; }
    }
}
