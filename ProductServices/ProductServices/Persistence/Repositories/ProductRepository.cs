using ProductServices.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductServices.Models.Entities;
using ProductServices.Models;
using System.Data.Entity;
using RefactorThis.GraphDiff;

namespace ProductServices.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private App1DbContext _context;

        public ProductRepository(App1DbContext context)
        {
            _context = context;
        }

        public void Add(Product entity)
        {
            _context.Products.Add(entity);
        }

        public Product GetProduct(int productId)
        {
            return _context
                    .Products
                    .Include(p => p.Tags)
                    .SingleOrDefault(p => p.ProductId == productId);
        }

        public IEnumerable<Product> GetProductsByPage(int numRows, int skip)
        {
            return _context
                    .Products
                    .OrderBy(p => p.ProductName)
                    .Skip(skip)
                    .Take(numRows)
                    .Include(p => p.Tags);                    
        }

        public void Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            _context.UpdateGraph(product, map => map.OwnedCollection(p => p.Tags));
        }
    }
}
