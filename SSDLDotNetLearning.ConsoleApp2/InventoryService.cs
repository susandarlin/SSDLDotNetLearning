using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDLDotNetLearning.ConsoleApp2;

internal class InventoryService
{
    public void ViewProducts()
    {
        Console.WriteLine("Product List");
        foreach (var product in Data.Products)
        {
            Console.WriteLine($"Id: {product.Id}, Code: {product.Code}, Name: {product.Name}, Price: {product.Price}, Qty: {product.Qty}, Category: {product.Category}");
        }
    }
}
