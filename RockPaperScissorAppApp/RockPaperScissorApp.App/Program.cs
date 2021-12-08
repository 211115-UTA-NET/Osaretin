

// app to play rock-paper-scissors with the computer

// required features:
// - play multiple rounds
// - get a summary/record of all the rounds played so far

// stretch goal features:
// - persistence (save data somehow, it will remember past game history) (and clear history)
// - play more complex variants of RPS (like RPS+lizard+spock)
// - logging (to help with debugging the app if something goes wrong)
// - some way to have more than 2 players at a time
// - support both player vs player and player vs computer
// - difficulty settings for the computer (remembers your moves and tries to predict)

// - in general, we want to write something simple
//    but in a way that allows for extending it / generalizing it in the future.

namespace RockPaperScissorsApp.App
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to RockPaperScissors App");
            Console.WriteLine("Enter 1 for one player. Enter 2 for two Player ");


           int numOfPlayer =Int32.Parse(Console.ReadLine());

            string name = "";
            string name2 = "";

            if (numOfPlayer == 1)
            {
                Console.WriteLine("Enter your name to beging");
                name = Console.ReadLine();
            }
            else if(numOfPlayer == 2)
            {
                Console.WriteLine("Enter  Player 1 name and press enter");
                name = Console.ReadLine();
                Console.WriteLine("Enter  Player 2 name and press enter");
                name2 = Console.ReadLine();

            }

           
            var game = new Game(name);
            var game2 = new Game(name, name2);


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Play a round? (y/n) ");

                string? input = Console.ReadLine();

                if (input != "y") { break; }

                if (numOfPlayer == 1)
                    game.PlayRound();
                else if (numOfPlayer == 2)
                    game2.PlayRound();

            }

            string summary = "";
            if (numOfPlayer == 1)
            {
                 summary = game.Summary;
            }
            else if (numOfPlayer == 2)
                 summary = game2.Summary;


            Console.WriteLine(summary);
        }
    }
}
