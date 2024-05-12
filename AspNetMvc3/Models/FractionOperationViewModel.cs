namespace AspNetMvc3.Models
{
    public class FractionsOperationViewModel
    {
        public Fractions Fractions1 { get; set; }
        public Fractions Fractions2 { get; set; }
        public string Operation { get; set; }
        public string Result { get; set; }

        public FractionsOperationViewModel()
        {
            Fractions1 = new Fractions();
            Fractions2 = new Fractions();
        }
    }
}
