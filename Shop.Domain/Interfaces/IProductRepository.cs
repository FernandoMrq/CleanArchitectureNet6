using Shop.Domain.Entities;

namespace Shop.Domain.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
    }
}
