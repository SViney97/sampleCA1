using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace sampleCA1
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            List<Player> allplayers = new List<Player>();
            allplayers.Add(player1);
            allplayers.Add(player2);
            allplayers.Add(player3);
            allplayers.Add(player4);
            allplayers.Add(player5);

            //player1.IncreaseScore(1);
            //player2.IncreaseScore(10);

            Display(allplayers);
            GetScores(allplayers);
            DisplayPlayerDetails(allplayers);

            allplayers.Sort();
            allplayers.Reverse();

            WriteLine($"highest score is {Player.HighScore}");
        }

        private static void GetScores(List<Player> allplayers)
        {
            WriteLine("enter in number of players to add a score for =>>> ");
            string input = ReadLine();
            int inputNumberofPlayers = int.Parse(input);

            while (inputNumberofPlayers != 0)
            {
                Player selectedplayer = allplayers.ElementAt(inputNumberofPlayers - 1);

                selectedplayer.IncreaseScore(1);

                Display(allplayers);

                WriteLine("enter in number of players to add a score for =>>> ");
                inputNumberofPlayers = int.Parse(ReadLine());

            }
        }

        private static void Display(List<Player> players)
        {
            WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", "Player1", "Player2", "Player3", "Player4", "Player5");

            foreach(Player player in players)
            {
                Write("{0,-15}",player.Score);
            }

            WriteLine();
        }

        private static void DisplayPlayerDetails(List<Player>players)
        {
            WriteLine($"{"playerID"}\t{"PlayerName"}\t{"Score"}");
            foreach(Player player in players)
            {
                WriteLine(player);
            }
        }
    }
}
