using System;

namespace Assignment2
{
    internal class Product
    {
        //2)create a class products and write properties for productid,productname,price,UnitOfMeasurement,Qty
        
        
        //Property for Product ID
        public int ProductId { get; set; }

        // Property for Product Name
        public string ProductName { get; set; }

        // Property for Price
        public decimal Price { get; set; }

        // Property for Unit of Measurement
        public string UnitOfMeasurement { get; set; }

        // Property for Quantity
        public int Qty { get; set; }

        // Constructor to initialize properties
     public Product(int productId, string productName, decimal price, string unitOfMeasurement, int qty)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            UnitOfMeasurement = unitOfMeasurement;
            Qty = qty;
        }
    }
}

internal class Products
{
    static void Main(string[] args)
    {

    }
}
