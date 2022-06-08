using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " oyununa kampanya eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " oyunundaki kampyanya bitti");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " oyunundaki kampanya güncellendi");
        }
    }
}
