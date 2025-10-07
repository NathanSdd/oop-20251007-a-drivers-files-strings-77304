using oop_20251007_a_drivers_files_strings_77304.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings_77304.RunDemos
{
    public class ProductDriver
    {
        public void DisplayProducts(List<Product> products)
        {
            Console.WriteLine("List of Products:\n");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
