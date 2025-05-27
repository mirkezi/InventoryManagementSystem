using System;

public class InventoryManagementSystem
{
    // Variable declaration
    static List<string> productName = new List<string>();
    static List<decimal> productPrice = new List<decimal>();
    static List<int> productStock = new List<int>();

    // Main function to display interface and allow for user method () choice.
    static void Main(string[] args)
    {
        while (true)
        {
            // Display interface with available option for user.
            Console.WriteLine("Inventory Management System:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Stock");
            Console.WriteLine("3. View Inventory");
            Console.WriteLine("4. Remove Product");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            // Use switch conditional statement to apply logic.
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
        decimal price = Convert.ToDecimal(Console.ReadLine());
        productPrice.Add(price);

        Console.WriteLine("Enter product stock: ");
        int stock = Convert.ToInt32(Console.ReadLine());
        productStock.Add(stock);

        Console.WriteLine($"Product {name} added successfully.");
    }
    
    // UpdateStock() method
    static void UpdateStock()
    {
        // Prompt the user for a product number, then display product name and actual stock, 
        // lastly prompt for new stock and display to user.
        if (productName.Count == 0)
        {
            Console.WriteLine("No products available in your inventory.");
            return;
        }
        else
        {
            Console.WriteLine("Enter product number you wish to update stock: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= productName.Count)
            {
                Console.WriteLine($"{productName[choice - 1]} stock: {productStock[choice - 1]}");
                Console.WriteLine("Insert new stock: ");
                productStock[choice - 1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{productName[choice - 1]} updated stock: {productStock[choice - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid product number");
                return;
            }
        }
    }
    
    // ViewInventory() method
    static void ViewInventory()
    {
        // Display a list of products available in inventory with name, price and stock.
        if (productName.Count == 0)
        {
            Console.WriteLine("No products available in your inventory");
        }
        else
        {
            Console.WriteLine("List of products in your inventory: ");

            for (int i = 0; i < productName.Count; i++)
            {
                Console.WriteLine($"{i + 1} -> Product: {productName[i]} / Price: {productPrice[i]} / Stock: {productStock[i]}");
            }
        }    
    }

    // RemoveProduct() method
    static void RemoveProduct()
    {
        // Prompt the user for product number, remove from all three lists and display successful message.
        if (productName.Count == 0)
        {
            Console.WriteLine("No products available in your inventory");
        }
        else
        {
            Console.WriteLine("Enter product number you wish to remove: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= productName.Count)
            {
                int i = choice - 1;
                productName.RemoveAt(i);
                productPrice.RemoveAt(i);
                productStock.RemoveAt(i);
                Console.WriteLine("Product successfully removed from inventory.");
            }
            else
            {
                Console.WriteLine("Invalid product number.");
                return;
            }
        }
    }
}
