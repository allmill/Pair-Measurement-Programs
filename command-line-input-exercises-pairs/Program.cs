using System;

namespace command_line_input_exercises_pairs
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.

        

        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {
            // Title and Greeting
            Console.WriteLine("Change Calculator");
            Console.WriteLine("Please enter the amount of the bill: ");

            // Grab the total from the user & parse string into double
            string totalBill = Console.ReadLine();
            decimal billAmount = decimal.Parse(totalBill);

            //Ask user for amount tendered & parse string into double
            Console.WriteLine("Please enter the amount tendered: ");
            string amount = Console.ReadLine();
            decimal tenderedAmount = decimal.Parse(amount);

            decimal changeAmount = tenderedAmount - billAmount;
            Console.WriteLine($"The change required = {changeAmount:C2}");



        }
    }
}
