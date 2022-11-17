using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class History
    {
        // for save Game's ID  for outputting in game's history
        public string GameIdStr;

        public GameAccount MainUser;
        public GameAccount OpponentUser;

        public string UserGameResultRating;

        public string UserGameStatus { set; get; }
        public string OpponentGameStatus { set; get; }

        public int MainUserRating;

        public string OpponentGameResultRating;

        // 
        
        public History(GameAccount user, GameAccount opponentUser, BaseGame game, GameResultStatus status, bool isVip, bool isCheater)
        {
            this.GameIdStr = game.GameIdStr;
            MainUser = user;
            this.OpponentUser = opponentUser;
            MainUserRating = MainUser.CurrentRating;
            UserGameStatus = status.ToString();

            // output game's history for one player game
            if (!game.TwoGamers)
            {
               OutputGameHistory(game.ZeroGameRating, game.GameRating, isVip, isCheater);
            }
            // output for games played by 2 players
           else
            {
                OutputGameHistory(game.GameRating, game.GameRating, isVip, isCheater);
            }
        }

        public void OutputData(int data1, int data2, int data3)
        {
             if (UserGameStatus.Equals("win"))
                {
                    OpponentGameStatus = GameResultStatus.loose.ToString();
                    OpponentGameResultRating = (data1 * -1).ToString();
                    UserGameResultRating = data2.ToString();
                }
             else
                {
                    UserGameResultRating = (data2/ data3 * -1).ToString();
                    OpponentGameStatus = GameResultStatus.win.ToString();
                    OpponentGameResultRating = data1.ToString();
                }
        }

        public void OutputGameHistory (int data1, int data2,  bool isVip, bool isCheater){
            if (!isCheater && !isVip)
            {
                OutputData(data1, data2, 1);
            }
            else if (isCheater)
            {
                OutputData(data1, data2, 2);
            }
            else if (isVip)
            {
                OutputData(data1, data2 * 2, 1);
            }
        }
    }
}

