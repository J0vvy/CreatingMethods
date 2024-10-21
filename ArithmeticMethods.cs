using System;

namespace HelloWorld
{
    public class Program
    {
        // Amount field
        public static int Amount = 8; // Make Amount static to access it in the static method

        public static void Main(string[] args)
        {
            // Call the Multiply method and print the result
            Console.WriteLine(Multiply(Amount, 5)); // Use the Amount variable
              Console.WriteLine(Exponent(Amount));
              Console.WriteLine(Division(Amount, 2));
                
            
            Console.WriteLine("Hello, World!");
            Console.Beep();
        }

        // Multiply method
        public static int Multiply(int amount, int multiplication) // Method declaration
        {
            return amount * multiplication; // Return the product
        }
        //Exponents
         public static int Exponent(int amount) // Method declaration
        {
            return amount * amount; // Return the product
        }
        //Division Methods
          public static int Division(int amount, int intensity) // Method declaration
        {
            return amount / intensity; // Return the product
        }
    
    }
}
