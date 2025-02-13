class Program
{
    static void Main()
    {
        Console.WriteLine("WELCOME TO THE RANDOMIK GAME!!!!");

        Random random = new Random();
        bool playAgain = true;
        int number;
        int guess;
        int guesses;
        string response;

        while (playAgain)
        {
            number = random.Next(1, 101);
            guess = 0;
            guesses = 0;

            while (guess != number)
            {
                Console.WriteLine("Guess a number between 1 - 100");

                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                if (guess > number)
                {
                    Console.WriteLine($"{guess} is too high!");
                }
                else if (guess < number)
                {
                    Console.WriteLine($"{guess} is too low!");
                }
                guesses++;
            }

            Console.WriteLine("You win!!");
            Console.WriteLine($"Guesses: {guesses}");
            Console.WriteLine("Would you like to play again? (Y/N) ");

            response = Console.ReadLine()?.ToUpper() ?? "";

            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                Console.WriteLine("See you soon!");
                playAgain = false;
            }
        }
    }
}
