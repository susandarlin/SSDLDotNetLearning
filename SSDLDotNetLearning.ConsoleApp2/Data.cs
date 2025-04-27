using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDLDotNetLearning.ConsoleApp2;

internal class Data
{
    public static List<Product> Products = new List<Product>()
    {
        new Product(1, "P001", "Apple", 1000m, 100, "Fruit"),
        new Product(2, "P002", "Banana", 2000m, 200, "Fruit"),
        new Product(3, "P003", "Orange", 3000m, 300, "Fruit")
    };
}
