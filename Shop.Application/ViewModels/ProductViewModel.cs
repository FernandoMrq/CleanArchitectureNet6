using Shop.Domain.Entities;

namespace Shop.Application.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product>? Products { get; set; }
    }
}
