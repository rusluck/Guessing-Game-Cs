using System;

namespace program
{
    class main
    {
        static void Main()
        {
            Console.WriteLine("Guess the number in C#!");
            Console.WriteLine("The ranges are between 0 and 9223372036854775807\n");

  
            Console.WriteLine("Hint: It is mostly arround 15 to 16 digits and is always positive.\n");

            long secretNumber = new Random().NextInt64();
            

            while(true)
            {
                try
                {
                    Console.WriteLine("Enter your guess.");
                    long guess = Convert.ToInt64(Console.ReadLine());
                    if (guess > secretNumber)
                    {
                        Console.WriteLine("Too big!");
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Too Small!");
                    }
                    else
                    {
                        Console.WriteLine("You Win!");
                        Console.WriteLine("Do you wanna play again? [y]");

                        string playAgain = Convert.ToString(Console.ReadLine());

                        if (playAgain == "y")
                        {
                            Console.WriteLine("Let's play again!\n");
                            secretNumber = new Random().NextInt64();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Thanks for playing");
                            break;
                        }
                    }
                }
                catch(System.OverflowException)
                {
                    Console.WriteLine("There was an error");
                    Console.WriteLine("Please choose a number between -9223372036854775808 and 9223372036854775807.\n");
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("There was an error.");
                    Console.WriteLine("Please choose an integer type.");
                }
            }
        }
    }
}