# InventoryManagementSystem

Hello and welcome to my Repo!

This project is an assignment of the Microsoft Back-End developer professional certificate, 
specifically tasked to display basic knowledge and understanding of C# programming language.

After choosing one of the challanges proposed, the course requires to:

 1. Describe the project functional and non-functional requirements.
 2. Generate a flowchart/diagramm to explain and verify the application flow.
 3. Describe the application design.
 4. Develop the application code.
 5. Run and test the application, relying on tools such as VS Code debugger / Github Copilot.

# Project Requirements:
 
1. Functional:

    The application must allow user to add products, update stock, view all products added and their stock, remove products from inventory.

2. Non-Functional:

    This app should have a slim interface that allow user to operate easily and effortlessly.

# Flowchart:

The designed flowchart is in the project directory under 'InventoryManagementSystem.jpg'.

# Describe the application Design:

1. Main() method to display interface. Based on while loop, until user choose the exit option.

2. AddProduct() method to add a new product with name, price and stock.

3. UpdateStock() method to access a product and modify the stock. Check if any product has been added, if not return; + ask which to update + modify data.

4. ViewInventory() method to view all products added. Check if any product has been added, if not return; + provide user list of products.   

5. RemoveProducts() method remove a previously added product. Check if any product has been added, if not return; + ask which product to remove.
    
# Develop the application code:

The entire application code will be in the project directory under 'Program.cs'.