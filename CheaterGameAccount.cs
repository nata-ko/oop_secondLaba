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
            IsCheater = true;
        }

       

        public override void LooseGame(GameAccount opponent, BaseGame game)
        {
            GetExeption(CheckRating(game.GameRating));
            this.CurrentRating -= game.GameRating / 2;
            PlayedGameResult(this, opponent, game, GameResultStatus.loose, IsVip, IsCheater);
        }
    }
}
