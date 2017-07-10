using ProductServices.Models.Dtos;
using ProductServices.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductServices.Models.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductsByPage(int numRows, int skip);
        Product GetProduct(int productId);
        void UpdateProduct(Product product);
    }
}
