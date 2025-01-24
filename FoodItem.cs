using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_3
{
    // This creates placeholders for the values. 
    public class FoodItem
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public int Quantity { get; set; }

        public string ExpirationDate { get; set; }


        // This is a constructor that neatley assigns values every time that you create a new FoodItem
        public FoodItem(string name, string category, int quantity, string expirationDate)
        {
            Name = name;
            Category = category;        
            Quantity = quantity;
            ExpirationDate = expirationDate;

        }

        // Override ToString for easy display
        public override string ToString()
        {
            return $"Name: {Name}, Category: {Category}, Quantity: {Quantity}, Expiration Date: {ExpirationDate}";
        }
    }
}
