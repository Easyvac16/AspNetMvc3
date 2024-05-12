namespace AspNetMvc3.Models
{
    public class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public double EngineSize { get; set; }

        public override string ToString()
        {
            return $"Name:{Name} Color:{Color} Manufacturer:{Manufacturer} Year:{Year} Engine:{EngineSize}";
        }
    }
}
