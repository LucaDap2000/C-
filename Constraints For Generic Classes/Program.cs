using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints_For_Generic_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Box<int> boxInt = new Box<int>();
            // Box<Book> bookBox = new Box<Book>();

            Repository<Product> repository = new Repository<Product>();
            var product = new Product();
            repository.Add(product);
        }
    }

    class Book
    {

    }

    class Product : IEntity
    {
        public int Id { get; }
    }
}
