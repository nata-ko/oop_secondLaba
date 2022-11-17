using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class CheaterGameAccount : GameAccount
    {

        public CheaterGameAccount(string name) : base(name)
        {
            isCheater = true;
        }

       

        public override void LooseGame(GameAccount opponent, BaseGame game)
        {
            GetExeption(CheckRating(this, game.GameRatingDefine()), this);
            this.CurrentRating = (CheckRating(this, game.GameRatingDefine() / 2)) ? this.CurrentRating - (game.GameRatingDefine() / 2) : 1;
            PlayedGameResult(this, opponent, game, GameResultStatus.loose, isVip, isCheater);
        }
    }
}
