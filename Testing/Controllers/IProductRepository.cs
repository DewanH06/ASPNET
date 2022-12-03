using Testing.Models;

namespace Testing.Controllers
{
    internal interface IProductRepository
    {
        object GetAllProducts();
        object GetProduct(int id);
        void UpdateProduct(Product product);
    }
}