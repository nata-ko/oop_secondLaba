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
            if(this.CurrentRating - beforeChangesRating > game.GameRating)
            {
                this.CurrentRating += game.GameRatingDefine() * 2;
                isVip = true;  
            }
            else
            {
                this.CurrentRating += game.GameRatingDefine();
                isVip = false;
            }
            
            opponent.CurrentRating = (CheckRating(opponent, game.GameRatingDefine())) ? opponent.CurrentRating - (game.GameRatingDefine()) : 1;
            PlayedGameResult(this, opponent, game, GameResultStatus.win, isVip, isCheater);
        }


        // change Game -> Base Game
        public override void LooseGame(GameAccount opponent, BaseGame  game)
        {
            base.LooseGame(opponent, game);
            // remember user's rating if he failed 
            beforeChangesRating = this.CurrentRating;
        }



    }
}
