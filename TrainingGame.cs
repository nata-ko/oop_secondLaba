using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class TrainingGame:BaseGame
    {
       
        public TrainingGame() {
            BaseGameInit();
           
        }

        public override int GameRatingDefine()
        {
            return GameRating = 0;
        }




    }
}
