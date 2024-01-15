using System;

class Program
{
    static void Main(string[] args)
    {
        bool game_over = false;
        while (game_over == false)
        {
            // where the user specified the number...
            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());

            // randomizing the magic number
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guess_count = 0;
            while (true)
            {
                Console.Write("Guess the magical number! ");
                int guess = int.Parse(Console.ReadLine());
                guess_count++;
                if (guess == number)
                {
                    Console.WriteLine("Congratulations! you guessed the number");
                    Console.WriteLine($"It took you {guess_count} attempts");
                    break;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Go lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Go higher");
                }

            }
            Console.Write("Do you want to play again(y/n) ");
            string play_again = Console.ReadLine();
            if (play_again == "y")
            {
               game_over = false;
            }
            else
            {
                game_over = true;
            }
        }       
    }
}