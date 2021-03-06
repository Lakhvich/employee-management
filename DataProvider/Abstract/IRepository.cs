﻿using DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Abstract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll { get; }
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
