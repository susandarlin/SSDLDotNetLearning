using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDLDotNetLearning.ConsoleApp2;

internal class InventoryService
{
    public void CreateProduct()
    {
        Console.WriteLine("Input Product Name: ");
        string productName = Console.ReadLine()!;

        Console.WriteLine("Input Product Price: ");
        string price = Console.ReadLine()!;

        decimal d_price = Convert.ToDecimal(price);

        Console.WriteLine("Input Product Quantity: ");
        string qty = Console.ReadLine()!;
        int d_qty = Convert.ToInt16(qty);

        Product product = new Product(4, "P004", productName, d_price, d_qty, "Fruit");
        Data.Products.Add(product);

        Console.WriteLine("Product Created Successfully");
    }
    public void ViewProducts()
    {
        Console.WriteLine("Product List");
        foreach (var product in Data.Products)
        {
            Console.WriteLine($"Id: {product.Id}, Code: {product.Code}, Name: {product.Name}, Price: {product.Price}, Qty: {product.Qty}, Category: {product.Category}");
        }
    }
}
