using System;

namespace MartianWeight
{
    /*
    In case you've ever pondered how much you weight on Mars, here's the calculation:
    Wm = We* 0.378
    where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

    Write a command line program which accepts a series of Earth weights from the user  
    and displays each Earth weight as itself, and its Martian equivalent.


    C:\Users> MartianWeight  
    Enter a series of Earth weights (space-separated): 98 235 185

    98 lbs.on Earth, is 37 lbs.on Mars.
    235 lbs.on Earth, is 88 lbs.on Mars.
    185 lbs.on Earth, is 69 lbs.on Mars. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            //greeting / initializing context
            Console.WriteLine("Martian Weight Calculator Program");
            Console.WriteLine("Please enter the weights of objects as they are on Earth: ");

            //grab value(s)
            string userInput = Console.ReadLine();
            //const for mars weight % of earth's
            const decimal weightPercentOnMars = 0.378M;

            string[] objectWeight = userInput.Split(new char[] { ' ', ',', '|' });

            //loop through each weight value in objectWeight array

            for (int index = 0; index < objectWeight.Length; index++)
            {
                // Read the individual value as a decimal
                decimal originalWeight = decimal.Parse(objectWeight[index]);
                // Convert Earth weight to Mars weight
                decimal weightOnMars = originalWeight * weightPercentOnMars;
                
                //present calculation to user as clean integers, may be off by 1 due to rounding
                Console.WriteLine($"Weight on Earth: {(int)originalWeight}lbs | Weight on Mars: {(int)weightOnMars}lbs");
            }

            //maintain window open with console read
            Console.Read();
        }
    }
}
