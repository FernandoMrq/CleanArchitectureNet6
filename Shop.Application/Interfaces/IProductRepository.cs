using Shop.Domain.Entities;

namespace Shop.Application.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
    }
}
