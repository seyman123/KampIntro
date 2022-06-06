using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class GamerCheckManager : IGamerCheckReal
    {
        public bool CheckReal(Gamer gamer)
        {
            if ( gamer.DateOfYear < 2003)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
