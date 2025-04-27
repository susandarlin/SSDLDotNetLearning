using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDLDotNetLearning.ConsoleApp2;

internal class Product
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Qty { get; set; }
    public string Category { get; set; }

    public Product(int id, string code, string name, decimal price, int qty, string category)
    {
        Id = id;
        Code = code;
        Name = name;
        Price = price;
        Qty = qty;
        Category = category;
    }
}
