using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal abstract class BaseGame
    {
        private static  int GameId = 20042904;
      
        public string GameIdStr { get; set; }

        public int GameRating { get; set; }
        public int ZeroGameRating ;
        public bool TwoGamers;


        public void BaseGameInit()
        {
            GameIdStr = GameId.ToString();
            GameId++;
            GameRating = new Random().Next(1, 20);
            TwoGamers = true;
            ZeroGameRating= 0;

        }

        // game's rating define
        public virtual int GameRatingDefine()
        {
            return GameRating;
        }


        // try to create method for PlayGame
        public virtual void PlayGame(GameAccount user, GameAccount opponent, BaseGame game)
        {
            int dice = new Random().Next(1, 6);
            if(dice > 3)
            {
                user.WinGame(opponent, game);
                opponent.LooseGame(user, game);
            }
            else
            {
                user.LooseGame(opponent, game);
                opponent.WinGame(user, game);
            }
        }
    }
}
