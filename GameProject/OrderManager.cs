using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class OrderManager : IOrderService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " siparişi verildi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " siparişi silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " siparişi güncellendi");
        }
    }
}
