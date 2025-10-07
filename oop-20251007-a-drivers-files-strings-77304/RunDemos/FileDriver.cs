using oop_20251007_a_drivers_files_strings_77304.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings_77304.RunDemos
{
    public class FileDriver
    {
        public void WriteProductsToFile(List<Product> products, string folderPath, string fileName)
        {
            // Ensure the output folder exists
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Combine folder path and file name
            string filePath = Path.Combine(folderPath, fileName);

            // Write products to file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("=== Product List ===");
                writer.WriteLine($"Generated on: {DateTime.Now}\n");

                foreach (var product in products)
                {
                    writer.WriteLine(product.ToString());
                }
            }

            Console.WriteLine($"\nProducts successfully written to: {Path.GetFullPath(filePath)}");
        }
    }
}





    //public static class FileDriver
    //{
    //    public static void Run()
    //    {
    //        Console.WriteLine("FileDriver.Run() called");
    //        WriteToTextFile();
    //        WriteMoviesToFile();
    //    }

//    public static void WriteToTextFile()
//    {
//        Console.WriteLine("FileDriver.WriteToTextFile() called");
//        string[] lines = { "First line", "Second line", "Third line" };
//        string fileToWrite = "../../../output/demo.txt";
//        File.WriteAllLines(fileToWrite, lines);
//        Console.WriteLine($"Wrote to file: {fileToWrite}");

//    }

//    public static void WriteMoviesToFile()
//    {
//        Console.WriteLine("FileDriver.WriteMoviesToFile() called");

//        List<Movie> movies = Repositories.MovieRepository.GetAllMovies();
//        List<string> movieLines = new List<string>();

//        foreach (Movie movie in movies)
//        {
//            movieLines.Add(movie.ToString());
//        }
//        string fileToWrite = "../../../output/movies.txt";
//        File.WriteAllLines(fileToWrite, movieLines);
//        Console.WriteLine($"Wrote to file: {fileToWrite}");
//    }

//}
