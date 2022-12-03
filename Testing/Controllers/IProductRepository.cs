using Testing.Models;

namespace Testing.Controllers
{
    internal interface IProductRepository
    {
        object AssignCategory();
        void DeleteProduct(Product product);
        object GetAllProducts();
        object GetProduct(int id);
        void InsertProduct(Product productToInsert);
        void UpdateProduct(Product product);
    }
}