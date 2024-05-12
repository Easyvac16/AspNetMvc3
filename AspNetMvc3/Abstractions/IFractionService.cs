using AspNetMvc3.Models;

namespace AspNetMvc3.Abstractions
{
    public interface IFractionservice
    {
        public bool Calculate(FractionsOperationViewModel model);
    }
}
