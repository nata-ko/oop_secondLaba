using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class GameAccount
    {
        public string UserName { get; set; }
        public bool isVip = false;
        public bool isCheater = false;
        public int CurrentRating { get; set; }
        private List<History> gameAccountStatus = new List<History>();



        public GameAccount(string name)
        {
            UserName = name;
            CurrentRating = new Random().Next(1, 20);
        }


        public static bool CheckRating(GameAccount user, int gameRating)
        {
            return user.CurrentRating - gameRating > 0;
        }


        public static void  GetExeption(Boolean checkRating, GameAccount player)
        {
            if (!checkRating)
            {
                Console.WriteLine($"\t\t\tERROR! {player.UserName}'s rating is less than 0! UPDATED {player.UserName}'S RATING = 1");
            }
        }
        public string GetStatus()
            {
                var result = new System.Text.StringBuilder();
                result.AppendLine($"for current user - {this.UserName}\n");
                result.AppendLine("Game's ID\t\tPoints\tStatus\tRating\t\tOpponent\tOpponent's points\tOpponent's Status");
                foreach (var item in gameAccountStatus)
                {
                    result.AppendLine($"{item.GameIdStr}\t\t{item.UserGameResultRating}\t{item.UserGameStatus}\t{item.MainUserRating}\t\t{item.OpponentUser.UserName}\t\t{item.OpponentGameResultRating}\t\t\t{item.OpponentGameStatus}");
                }
                return result.ToString();
            }


        // ------------------ Modifications for the second lab -------------------

        public virtual void WinGame(GameAccount opponent, BaseGame game)
        {
            this.CurrentRating += game.GameRatingDefine();
            PlayedGameResult(this, opponent, game, GameResultStatus.win, isVip, isCheater);
        }

        public virtual void LooseGame(GameAccount opponent, BaseGame game)
        {
            GetExeption(CheckRating(this, game.GameRating), this);
            this.CurrentRating = (CheckRating(this, game.GameRatingDefine())) ? this.CurrentRating - game.GameRatingDefine() : 1;
            PlayedGameResult(this, opponent, game, GameResultStatus.loose, isVip, isCheater);
        }

        public static void PlayedGameResult(GameAccount user, GameAccount opponent, BaseGame game, GameResultStatus grs, bool isVip, bool isCheater)
        {
            user.gameAccountStatus.Add(new History(user, opponent, game, grs, isVip, isCheater));
        }

    }    
}

