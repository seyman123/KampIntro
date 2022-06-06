using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class GameManager : IGameService
    {
        public void Sell(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu " + game.Name + " oyununu satın aldı");
        }
    }
}
