﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combine_GC_and_GI
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    internal interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
    }

    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Repository<T> : IRepository<T>
    {
        public void Add(T entity)
        {

        }

        public void Remove(T entity)
        {

        }
    }
}
