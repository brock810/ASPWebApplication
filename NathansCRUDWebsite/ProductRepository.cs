using System.Collections.Generic;
using System.Data;
using NathansCRUDWebsite.Models;
using Dapper;
namespace NathansCRUDWebsite
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("Select * from products");
        }

        public ProductRepo GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
