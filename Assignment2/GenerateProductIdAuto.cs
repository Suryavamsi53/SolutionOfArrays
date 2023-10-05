using System;

namespace Assignment2
{
    internal class ProductObject2
    {
        //5) Make changes in the above product class and generate a productid automatically
        private static int lastProductId = 0;

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

        public ProductObject2(string productName, decimal price, int qty)
        {
            // Automatically generate a new ProductId
            ProductId = ++lastProductId;

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

    internal class ArrayOfProducts1
    {
        static void Main(string[] args)
        {
            // Create an array to store 5 products
            ProductObject1[] products = new ProductObject1[5];

            // Accept data for each product
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                // Create a ProductObject1 instance, and it will generate a unique ProductId
                products[i] = new ProductObject2(productName, price, qty);

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
