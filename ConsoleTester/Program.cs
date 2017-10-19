using System;
using Assignment4;


namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataService = new Assignment4.DataService();

            var category = dataService.GetCategory(1);

            Console.WriteLine(category.Name);
            Console.WriteLine(category.Description);


            var product = dataService.GetProduct(1);

            Console.WriteLine(product.Name);
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Category.Name);

            Console.WriteLine("GetProductBySubstring test");
            var returnedProducts = dataService.GetProductBySubstring("chef");

            foreach (var valueTuple in returnedProducts)
            {
                Console.WriteLine(valueTuple.Item1);
                Console.WriteLine("with category: " + valueTuple.Item2);
                Console.WriteLine();
            }

            Console.WriteLine("GetOrderDetailsByProductId test");
            var returnedProduct2 = dataService.GetProductsByCategoryId(1);

            foreach (var valueTuple in returnedProduct2)
            {
                Console.WriteLine(valueTuple.Item1);
                Console.WriteLine("with category: " + valueTuple.Item2);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
