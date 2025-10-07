using oop_20251007_a_drivers_files_strings_77304.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings_77304.Repositories
{
    public class ProductRepository
    {
        public List<Product> Products { get; private set; }

        public ProductRepository()
        {
            Products = new List<Product>
            {
                new Product("Laptop", 999.99m),
                new Product("Smartphone", 699.50m),
                new Product("Headphones", 199.99m),
                new Product("Monitor", 249.00m),
                new Product("Keyboard", 89.99m)
            };
        }

        public List<Product> GetAllProducts()
        {
            return Products;
        }
    }
}
