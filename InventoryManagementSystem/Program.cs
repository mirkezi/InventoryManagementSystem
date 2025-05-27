using System;

public class InventoryManagementSystem
{
    // Variable declaration
    static List<string> product = new List<string>();
    static List<double> price = new List<double>();
    static List<int> stock = new List<int>();

    // Main function to display interface and allow for user method () choice.
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Inventory Management System:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Stock");
            Console.WriteLine("3. View Inventory");
            Console.WriteLine("4. Remove Product");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    UpdateStock();
                    break;
                case 3:
                    ViewInventory();
                    break;
                case 4:
                    RemoveProduct();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
    // AddProduct() method
    static void AddProduct()
    {

    }
    // UpdateStock() method
    static void UpdateStock()
    {

    }
    // ViewInventory() method
    static void ViewInventory()
    {

    }
    // RemoveProduct() method
    static void RemoveProduct()
    {
        
    }
}
