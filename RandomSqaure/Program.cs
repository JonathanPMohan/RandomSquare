using System;
using System.Collections.Generic;

namespace RandomSquare
{

    class Program
    {     
        static void Main(string[] args)
        {
            // Create List For Random Numbers //
            var randomNumbers = new List<int>();
            Random RandomNumber = new Random();

            // Loop to print Numbers Randomly from 1-50 // 
            for (int i = 0; i <= 20; i++)
            {
                // Set Variable to Generate Number between 0-50 //
                var randomNumber = RandomNumber.Next(1, 51);

                // Square Numbers //
                randomNumbers.Add(randomNumber * randomNumber);
            }

            // Remove All Odd Numbers //
            randomNumbers.RemoveAll(i => i % 2 != 0);

            // Print Numbers //
            foreach (int j in randomNumbers)
            {
               
                Console.WriteLine($"Number Is:{j}");
            }

            Console.ReadKey();
        }
    }

}
