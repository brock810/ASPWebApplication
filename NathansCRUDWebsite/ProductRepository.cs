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

        public Product GetProduct(int id)
        {
         return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERER PRODUCTID = @id",
                new { id = id});
        }

    }
}
