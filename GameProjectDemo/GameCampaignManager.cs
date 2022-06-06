using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class GameCampaignManager : IGameCampaignService
    {
        public void Add(Game game, GameCampaign gameCampaign)
        {
            Console.WriteLine(game.Name + " oyununa %" + gameCampaign.DiscountRate + " indirimi yapılarak yeni fiyatı : " + (game.Price - ((game.Price * gameCampaign.DiscountRate) / 100)) + " oldu");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " oyununa yapılan kampanyanın süresi dolmuştur");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " oyununa yapılan kampanya güncellendi");
        }
    }
}
