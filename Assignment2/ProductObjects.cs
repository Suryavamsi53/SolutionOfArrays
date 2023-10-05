using System;

namespace Assignment2
{
    internal class ProductObject
    {
        //3) create objects of class for 5 products

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

        public ProductObject(int productId, string productName, decimal price, int qty)
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

    internal class Program1
    {
        static void Main(string[] args)
        {
            // Create objects for 5 products
            ProductObject product1 = new ProductObject(1, "TOY-A", 25, 50);
            ProductObject product2 = new ProductObject(2, "TOY-B", 35, 30);
            ProductObject product3 = new ProductObject(3, "TOY-C", 55, 100);
            ProductObject product4 = new ProductObject(4, "TOY-D", 15, 75);
            ProductObject product5 = new ProductObject(5, "TOY-E", 45, 40);
        }
    }
}