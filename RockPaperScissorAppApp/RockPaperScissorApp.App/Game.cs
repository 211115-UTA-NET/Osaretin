using System;
namespace RockPaperScissorsApp.App
{
    public class Game
    {
        private string Player;
        private string Player2;
        private int gamecount = 0;
        private int gameswon = 0;
        private int gameLost = 0;
        private int numofplayer = 1;


        public string Summary
        {
            get
            {
                if (numofplayer == 1)
                return Player + " Played "+gamecount+ " game and won "+gameswon +" and lost "+gameLost;
                else
                    return Player +" and "+Player2 + " Played " + gamecount + " Games. " + Player + " won "+gameswon + " and "+Player2 +" won "+ gameLost+ " games ";

            }
        }


        public Game(string player1)
        {
            
            this.Player = player1;
        }

        public Game(string player1Name, string player2Name)
        {

            this.Player = player1Name;
            this.Player2 = player2Name;
            numofplayer = 2;

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

            if (player == cpu)
                winner = "Tie";
            else if (player == "Rock" && cpu == "scissors" || player == "Paper" && cpu == "Rock" || player == "scissors" && cpu == "Paper")
            {
                winner = Player + " Won!";
                gameswon++;
            }
            else
            {
                if(numofplayer == 1)
                winner = "You lost and CPU won!";
                else
                winner = Player2+" won!";
                gameLost++;
            }
            

            return  winner;
            

        }
        public void PlayRound()
        {

            string playerAns = "";
            string player2Ans = "";
            string CPU = "";
            Console.WriteLine("Press 1 for Rock");
            Console.WriteLine("Press 2 for Paper");
            Console.WriteLine("Press 3 for scissors");

            try
            {
                if (numofplayer == 1)
                {
                    Console.WriteLine(Player + " Enter a number");
                    playerAns = getPlayerResponse(Int32.Parse(Console.ReadLine()));
                    CPU = RockPaperScisGenerator();
                    Console.WriteLine("You Selected " + playerAns + " and CPU selected " + CPU);
                    Console.WriteLine(getTheWinner(playerAns, CPU));

                }

                else if (numofplayer == 2)
                {
                    Console.WriteLine(Player + " Enter a number");
                    playerAns = getPlayerResponse(Int32.Parse(Console.ReadLine()));
                    Console.WriteLine(Player2 + " Enter a number");
                    player2Ans = getPlayerResponse(Int32.Parse(Console.ReadLine()));
                    Console.WriteLine(Player + " selected " + playerAns + " and " + Player2 + " selected " + player2Ans);
                    Console.WriteLine(getTheWinner(playerAns, player2Ans));

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;

            }

            gamecount++;




            //throw new NotImplementedException();
        }
    }
}
