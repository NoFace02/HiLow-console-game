using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace HiLow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100); //Generating a number 
            int guessCount = 0;

            Console.WriteLine("||============================||");
            Console.WriteLine("||Welcome to my minigame HiLow||");
            Console.WriteLine("||============================||");
            Console.WriteLine("\n");

            while (true)
            {
                Console.Write("Pick a Number between 1 and 100: ");
                int guess = Convert.ToInt32 (Console.ReadLine()); //storing the user number
                guessCount++; 
                Console.Clear();

                if (guess == randomNumber)
                {
                    Console.Write($"Congrats! You guessed the number {randomNumber} in {guessCount} guesses! Press any key to exit: ");
                    break;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("||==================||");
                    Console.WriteLine($"||Its Higher than {guess}||");
                    Console.WriteLine("||==================||");
                    Console.WriteLine("\n");
                }
                else {
                    Console.WriteLine("||=================||");
                    Console.WriteLine($"||Its Lower than {guess}||");
                    Console.WriteLine("||=================||");
                    Console.WriteLine("\n");
                }

            }
            Console.ReadKey();

        }
    }
}
