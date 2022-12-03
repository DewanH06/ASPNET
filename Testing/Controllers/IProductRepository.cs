using Testing.Models;

namespace Testing.Controllers
{
    internal interface IProductRepository
    {
        object AssignCategory();
        object GetAllProducts();
        object GetProduct(int id);
        void InsertProduct(Product productToInsert);
        void UpdateProduct(Product product);
    }
}