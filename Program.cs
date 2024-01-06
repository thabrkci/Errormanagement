using System;

namespace Errormanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to enter a number and displaying the entered number on the screen.
            // However, in this section, try-catch-finally block is not used to check for errors.

            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("The number you entered: " + number);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Error:" + ex.Message.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("Operation completed");
            //}

            // Error management using the try-catch block.
            try
            {
                // A code snippet where an error might occur.
                // int a = int.Parse("test"); // This line causes a FormatException.
                int a = int.Parse("-2000000000");
            }
            // Separate catch blocks are used for ArgumentNullException, FormatException, and OverflowException.
            catch (ArgumentNullException kex)
            {
                // This block is executed when an empty value is entered.
                Console.WriteLine("You entered an empty value");
                Console.WriteLine(kex); // Prints the details of the error.
            }
            catch (FormatException kex)
            {
                // This block is executed when data in an invalid format is entered.
                Console.WriteLine("The data type is not appropriate");
                Console.WriteLine(kex); // Prints the details of the error.
            }
            catch (OverflowException kex)
            {
                // This block is executed when a too large or too small value is entered.
                Console.WriteLine("You entered a value that is too large or too small");
                Console.WriteLine(kex); // Prints the details of the error.
            }
        }
    }
}
