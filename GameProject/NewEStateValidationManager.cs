using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class NewEStateValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.FirstName == "İbrahim" && user.LastName == "Seyman" && user.BirthYear == 2001 && user.IdentityNumber == 29629454810)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
