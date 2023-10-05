using System;

namespace Assignment2
{
    internal class ProductObject1
    {

         //4) create a array of products class and take 5 products in the array to accept and display data.
        
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

        public ProductObject1(int productId, string productName, decimal price, int qty)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Qty = qty;
        }

        // Method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductId}");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: {Price:C2}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine();
        }
    }

    internal class ArrayOfProducts
    {
        static void Main(string[] args)
        {
            // Create an array to store 5 products
            ProductObject1[] products = new ProductObject1[5];

            // Accept data for each product
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");

                Console.Write("Product ID: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                // Create a ProductObject1 instance and add it to the array
                products[i] = new ProductObject1(productId, productName, price, qty);

                Console.WriteLine();
            }

            // Display product details
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Product {i + 1} Details:");
                products[i].DisplayProductDetails();
            }
        }
    }
}
