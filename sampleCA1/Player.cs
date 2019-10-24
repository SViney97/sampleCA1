using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace sampleCA1
{
    class Player: IComparable
    {
        #region //properties
        public int PlayerID { get; }
        public string PlayerName { get; set; }
        public int Score { get; private set; }
        public static int HighScore { get; private set; }
        #endregion //
        public Player()
        {

        }
        public Player(int id, string playersname, int score)
        {
            PlayerID = id;
            PlayerName = playersname;
            Score = score;
        }
        public void IncreaseScore (int Value)
        {
            if (Score <100)
            Score = Score + Value;

            if(Score > HighScore)
            {
                HighScore = Score;
            }
        }
        public override string ToString()
        {
            return $"{PlayerID}\t\t{PlayerName}\t\t{Score}";
        }
        public int CompareTo(object obj)
        {
            Player objectcomparingto = obj as Player;
            int returnvalue = this.Score.CompareTo(objectcomparingto.Score);
            return returnvalue;
        }
    }
}
