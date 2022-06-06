using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal interface IGameCampaignService
    {
        void Add(Game game, GameCampaign gameCampaign);
        void Delete(Game game);
        void Update(Game game);

    }
}
