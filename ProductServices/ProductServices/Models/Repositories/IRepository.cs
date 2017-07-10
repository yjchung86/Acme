﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductServices.Models.Repositories
{
    public interface IRepository<T> where T: class
    {
        void Add(T entity);
        void Remove(T entity);
    }
}
