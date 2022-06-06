using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal abstract class BaseGamerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Bir oyuncu kaybedildi : " + gamer.FirstName + " " + gamer.FirstName);
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Yeni bir oyuncu kayıt edildi : " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu bilgilerini güncelledi : " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
