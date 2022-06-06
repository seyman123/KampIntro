using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class ChildGamerManager : BaseGamerManager
    {

        private IGamerCheckReal _gamerCheckReal;

        public ChildGamerManager(IGamerCheckReal gamerCheckReal)
        {
            _gamerCheckReal = gamerCheckReal;
        }

        public override void Save(Gamer gamer)
        {
            if (_gamerCheckReal.CheckReal(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                Console.WriteLine("Yaşınız çocuk kategorisine uygun değil!");
            }
        }
    }
}
