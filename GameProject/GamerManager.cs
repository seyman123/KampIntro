using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IUserService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " oyuncusu başarıyla eklendi");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " oyuncu bilgileri yanlış. Kayıt başarısız");
            }
        }

        public void Delete(User gamer)
        {
            Console.WriteLine(gamer.FirstName + " oyuncusu kayıtlardan silindi");
        }

        public void Update(User gamer)
        {
            Console.WriteLine(gamer.FirstName + " oyuncusu bilgileri güncellendi");
        }
    }
}
