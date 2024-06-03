﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    internal interface IEntity
    {
        int Id { get; }
    }

    internal interface IRepository<T> where T : IEntity
    {
        void Add(T entity);
        void Remove(T entity);
    }

    internal class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class User : IEntity
    {
        public string Name { get; set; }
        public int Id { get; }
    }

    internal class  ProductRepository : IRepository<Product>
    {
        public void Add(Product entity)
        {

        }

        public void Remove(Product entity)
        {

        }
    }

    internal class UserRepository : IRepository<User>
    {
        public void Add(User entity)
        {

        }

        public void Remove(User entity)
        {

        }
    }
}
