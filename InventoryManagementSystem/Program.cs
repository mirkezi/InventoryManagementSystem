using System;

public class InventoryManagementSystem
{
    // Variable declaration
    static List<string> productName = new List<string>();
    static List<double> productPrice = new List<double>();
    static List<int> productStock = new List<int>();

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
        //Prompt the user for product name, price and stock. Display successful message.

        Console.WriteLine("Enter product name: ");
        string name = Console.ReadLine();
        productName.Add(name);

        Console.WriteLine("Enter product price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        productPrice.Add(price);

        Console.WriteLine("Enter product stock: ");
        int stock = Convert.ToInt32(Console.ReadLine());
        productStock.Add(stock);

        Console.WriteLine("Product added successfully.");
    }
    // UpdateStock() method
    static void UpdateStock()
    {
        if (productName.Count == 0)
        {
            Console.WriteLine("No products available in your inventory.");
            return;
        }
        Console.WriteLine("Enter product number you wish to update stock: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice < 0 && choice < productName.Count)
        {
            Console.WriteLine($"{productName[choice - 1]} stock: {productStock[choice - 1]}");
            Console.WriteLine("Insert new stock: ");
            productStock[choice - 1] = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Invalid product number");
            return;
        }
    }
    // ViewInventory() method
    static void ViewInventory()
    {
        if (productName.Count == 0)
        {
            Console.WriteLine("No products available in your inventory");
        }

        Console.WriteLine("List of products in your inventory: ");
        
        for (int i = 0; i < productName.Count; i++)
        {
            Console.WriteLine($"{i + 1} -> Product: {productName[i]} / Price: {productPrice[i]} / Stock: {productStock[i]}");
        }
    }
    // RemoveProduct() method
    static void RemoveProduct()
    {
        
    }
}
