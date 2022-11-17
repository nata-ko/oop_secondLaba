using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class OneUserRatingGame : BaseGame
    {
        
        public OneUserRatingGame() {
            TwoGamers = false;
            BaseGameInit();
        }

        
        public override void PlayGame(GameAccount user, GameAccount opponent, BaseGame game)
        {
            game.TwoGamers = false;
            int dice = new Random().Next(1,6);
            if (dice > 3)
            {
                user.WinGame(opponent, game);
            }
            else
            {
                user.LooseGame(opponent, game);
            }
            
        }







    }
}
