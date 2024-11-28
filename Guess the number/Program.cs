namespace Guess_the_number

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain) {
                guess = 0;
                guesses = 0;
                response = " ";
                number = random.Next(min, max + 1);

                while (guess != number) {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    int.TryParse(Console.ReadLine(), out guess);
                    Console.WriteLine("Guess : " + guess);
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You Win!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again? (Y = yes , N = no)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;

                } else if (response == "N") {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing!");
                }
            }
        }
    }
}
