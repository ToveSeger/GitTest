using System;
using System.Linq;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] numberArray = new int[5];
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
            }*/

            //ÖVNING 2
            //ett sätt
            int[] firstOne = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] secondOne = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine(string.Join(',', firstOne));
            Console.WriteLine(string.Join(',', secondOne));

            //alternativt sätt 

            Console.WriteLine(string.Join(',' ,firstOne));
            //Console.WriteLine(string.Join(',', firstOne.reverse));




        }
    }
}
