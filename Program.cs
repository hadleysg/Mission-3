// Hadley Garff 4-14
// This program will manage an inventory of food items for a local food bank
// The user should be able to add, delete, and print the food items

namespace Mission_3;

internal class Program
{
    // making the list to hold the food inventory
    static List<FoodItem> inventory = new List<FoodItem>();
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Food Bank Inventory!\n");
        while (true)
        {
            // Here we are informing the user how to manage the inventory
            Console.WriteLine("Would you like to:\n1. Add Food Items\n2. Delete Food Items\n3. Print List of Current Food Items\n4. Exit the Program\n");
            Console.WriteLine("Please enter the corresponding number.");

            // Based on the number they type, a function will run
            int actionChoice = 0;
            if (int.TryParse(Console.ReadLine(), out actionChoice))

                if (actionChoice == 1)
                {
                    AddFoodItem();
                }
                else if (actionChoice == 2)
                {
                    DeleteFoodItem();
                }
                else if (actionChoice == 3)
                {
                    PrintFoodItems();
                }
                else if (actionChoice == 4)
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                }
                // if they type a number that is not correspondant with a number given, they will be prompted to try again.
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
        }

        // If the user chooses to add food, this command will run. Prompting the user to enter the name, category, quantity, and expiration date.
        // This will then add to the food item to the inventory list
        static void AddFoodItem()
        {
            Console.WriteLine("You have chosen to enter a food item! Please enter the following information.");

            // Get name
            Console.Write("\nName of the food item: ");
            string name = "";
            name = Console.ReadLine();

            // Get category
            Console.Write("\nCategory of the food item: ");
            string category = "";
            category = Console.ReadLine();

            // Get quantity (validated)
            int quantity = 0;
            while (true)
            {
                Console.Write("\nQuantity of the food item: ");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                {
                    break; // Exit loop if valid input
                }
                Console.WriteLine("Invalid input. Please enter a positive integer for quantity.");
            }

            // Get expiration date
            Console.Write("\nExpiration date of the food item (MM/DD/YYYY): ");
            string expirationDate = " ";
            expirationDate = Console.ReadLine();

            // Add the food item to the inventory list
            inventory.Add(new FoodItem(name, category, quantity, expirationDate));
            Console.WriteLine("Food item added!\n");
        }


        // This is a method to delete a food item from the inventory
        static void DeleteFoodItem()
        {
            // if there is no food items, it will exit the user from the method
            if (inventory.Count == 0)
            {
                Console.WriteLine("\nNo food items in inventory to delete. Let's try again!\n");
                return;
            }

            // This lists out the current food items, in a number format
            Console.WriteLine("\nCurrent Food Items:");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            }

            int numSelected;
            while (true)
            {
                Console.Write("\nEnter the number of the item to delete: ");
                if (int.TryParse(Console.ReadLine(), out numSelected) && numSelected > 0 && numSelected <= inventory.Count)
                    break;
                Console.WriteLine("Invalid selection. Please try again.");
            }

            // This allows the user to remove the food item selected, based upon the inventory position
            inventory.RemoveAt(numSelected - 1);
            Console.WriteLine("Food item deleted successfully!\n");
        }

        // Method to print all food items in the inventory
        static void PrintFoodItems()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("\nNo food items in inventory. Let's try again!\n");
                return;
            }

            Console.WriteLine("\nCurrent Food Items:");
            foreach (var item in inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}