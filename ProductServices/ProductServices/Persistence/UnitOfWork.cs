using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductServices.Models.Repositories;
using ProductServices.Persistence.Repositories;

namespace ProductServices.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private App1DbContext _context;

        public IProductRepository Products
        {
            get; private set;
        }

        public UnitOfWork(App1DbContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
