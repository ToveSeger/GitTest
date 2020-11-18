using System;
using System.Linq;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[5];
            numberArray[0] = 13;
            numberArray[1] = 22;
            numberArray[2] = 3;
            numberArray[3] = 93;
            numberArray[4] = 1;

            Console.WriteLine("Check if you pickd a lucky number");
            string number = Console.ReadLine();
            int myNumber = Convert.ToInt32(number);

            for (int i = 0; i<numberArray.Length; i++)
            {
                if (myNumber == numberArray[i])
                {
                    Console.WriteLine("Winner winner chicken dinner!");
                }
                else
                {
                    Console.WriteLine("Sorry, not this time");
                }
            }

            Console.WriteLine(numberArray.Contains(myNumber));
            if (true)
            {
                Console.WriteLine("Congrats man!");
            }else
            {
                Console.WriteLine("Sorry, not this time");
            }
        }
    }
}
