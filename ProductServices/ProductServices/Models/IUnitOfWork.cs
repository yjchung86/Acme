using ProductServices.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductServices.Models
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        void Complete();
    }
}
