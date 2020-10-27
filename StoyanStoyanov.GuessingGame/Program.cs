using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StoyanStoyanov.GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();

            //Initial range can be modified per requirements;
            int num1 = randNum.Next(0, 50);

            bool status = false;

            do
            {
                Console.WriteLine("Guess a number between 0 and 50: ");
                int value = Convert.ToInt32(Console.ReadLine());

                if (value > num1)
                {
                    Console.WriteLine("Number is too high. Guess lower!");
                }
                else if (value < num1)
                {
                    Console.WriteLine("Number is too low. Guess higher!");
                }
                else 
                {
                    Console.WriteLine("You win the game!");
                    status = true;
                }

                //Insert an empty line;
                Console.WriteLine();
            } while (status == false);

            Console.WriteLine("Thank you for playing the guessing game!");
            Console.Write("Press key to finish!");
            //Any key inserted will close the command prompt;
            Console.ReadKey(true);
        }
    }
}
