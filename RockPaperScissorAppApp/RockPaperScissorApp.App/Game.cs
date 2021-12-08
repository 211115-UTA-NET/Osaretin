using System;
namespace RockPaperScissorsApp.App
{
    public class Game
    {


        public string Summary
        {
            get
            {
                return "(not implemented yet)";
            }
        }
        public string Player;


        public Game(string name)
        {
            
            this.Player = name;
        }



        public string RockPaperScisGenerator()
        {
            Random random = new Random();
            int num = random.Next(3);

            string selected = "";           

            if(num == 0)           
                selected = "Rock";
            else if(num == 1)
                selected = "Paper";
            else if (num == 2)
                selected = "scissors";

            return selected;

        }

        public string getPlayerResponse(int num)
        {
            num--;
            string selected = "";

            if (num == 0)
                selected = "Rock";
            else if (num == 1)
                selected = "Paper";
            else if (num == 2)
                selected = "scissors";

            return selected;

        }
        public string getTheWinner(string player, string cpu)
        {

            string winner = "";

            if (player  == cpu)
                winner = "Tie";
            else if (player == "Rock" && cpu == "scissors" || player =="Paper" && cpu == "Rock" || player == "scissors" && cpu == "Paper")
                winner = Player +" Won!";
            else 
                winner = "You lost and CPU won!";

            return  winner;
            

        }
        public void PlayRound()
        {
            Console.WriteLine("Welecome" + Player);
            Console.WriteLine("Press 1 for Rock");
            Console.WriteLine("Press 2 for Paper");
            Console.WriteLine("Press 3 for scissors");

            string playerAns = getPlayerResponse(Int32.Parse(Console.ReadLine()));

            string CPU = RockPaperScisGenerator();

            Console.WriteLine("You Selected " + playerAns + " and CPU selected " + CPU);

            Console.WriteLine(getTheWinner(playerAns, CPU));
            





            //throw new NotImplementedException();
        }
    }
}
