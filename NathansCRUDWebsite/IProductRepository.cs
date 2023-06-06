using System.Collections;
using System.Collections.Generic;
using NathansCRUDWebsite.Models;

namespace NathansCRUDWebsite
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
    }
}
