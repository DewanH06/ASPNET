using System;
using System.Collections.Generic;
using Testing.Models;
namespace Testing
{
    public interface IproductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
    }
}
