using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class VipGameAccount : GameAccount
    {
        public int beforeChangesRating;
        public VipGameAccount(string name) : base(name)
        {
            beforeChangesRating = base.CurrentRating;
            
        }

   
        // change Game -> Base Game
        public override void WinGame(GameAccount opponent, BaseGame game)
        {
            if(CurrentRating - beforeChangesRating > game.GameRating)
            {
                CurrentRating += game.GameRatingDefine() * 2;
                IsVip = true;  
            }
            else
            {
                CurrentRating += game.GameRatingDefine();
                IsVip = false;
            }
            
            PlayedGameResult(this, opponent, game, GameResultStatus.win, IsVip, IsCheater);
        }


        // change Game -> Base Game
        public override void LooseGame(GameAccount opponent, BaseGame  game)
        {
            base.LooseGame(opponent, game);
            // remember user's rating if he failed 
            beforeChangesRating = CurrentRating;
        }



    }
}
