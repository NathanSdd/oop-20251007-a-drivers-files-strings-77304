// See https://aka.ms/new-console-template for more information
using oop_20251007_a_drivers_files_strings_77304.Models;
using oop_20251007_a_drivers_files_strings_77304.Repositories;
using oop_20251007_a_drivers_files_strings_77304.RunDemos;

//AppDriver.Run();
//FileDriver.Run();
//MovieDriver.Run();
//StringDriver.Run();


class Program
{
    static void Main(string[] args)
    {
        // Create repository and get products
        ProductRepository repository = new ProductRepository();
        List<Product> products = repository.GetAllProducts();

        // Display products in console
        ProductDriver productDriver = new ProductDriver();
        productDriver.DisplayProducts(products);

        // Create output folder and write file
        FileDriver fileDriver = new FileDriver();
        string outputFolder = "../../../Output";       // Folder name
        string fileName = "products.txt";     // File name
        fileDriver.WriteProductsToFile(products, outputFolder, fileName);
    }
}


