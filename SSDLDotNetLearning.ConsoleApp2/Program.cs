// See https://aka.ms/new-console-template for more information
using SSDLDotNetLearning.ConsoleApp2;

BeforeSystem:
Console.WriteLine("Inventory Management System");

Console.WriteLine("1. View Products");
Console.WriteLine("2. Exit");

Console.Write("Select Option: ");
int option = Convert.ToInt32(Console.ReadLine());

InventoryService inventoryService = new InventoryService();

switch (option)
{
    case 1:
        Console.WriteLine("View Products");
        inventoryService.ViewProducts();
        break;
    case 2:
        Console.WriteLine("Exiting...");
        goto Exit;
}

goto BeforeSystem;

Exit:
Console.ReadKey();

