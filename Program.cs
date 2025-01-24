// Hadley Garff 4-14
// This program will manage an inventory of food items for a local food bank
// The user should be able to add, delete, and print the food items

using Mission_3;

// Declaration and Installation of FoodItem
FoodItem food;
food = new FoodItem();

// Here we are informing the user how to manage the inventory
Console.WriteLine("Welcome to the Food Bank Inventory!\n");
Console.WriteLine("Would you like to:\n1. Add Food Items\n2. Delete Food Items\n3. Print List of Current Food Items\n4. Exit the Program\n");
Console.WriteLine("Please enter the corresponding number.");

// Based on the number they type, a function will run
int actionChoice = 0;
actionChoice = Console.ReadLine();


if (actionChoice == "1")
{
    addFoodItem();
}
else if (actionChoice == "2")
{
    deleteFoodItem();
}
else if (actionChoice == "3")
{
    printFoodItems();
}
else if (actionChoice == "4")
{
    Console.WriteLine("Exiting the program. Goodbye!");
    return;
}
else
{
    Console.WriteLine("Invalid choice. Please try again.");
}

static void AddFoodItem()
{

}
