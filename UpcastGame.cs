using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class UpcastGame : BaseGame
    {
   
        public BaseGame DoUpcast( BaseGame game)
        {
            return game;
        }
    }
}
