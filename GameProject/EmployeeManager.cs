using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class EmployeeManager : IUserService
    {
        public void Add(User employee)
        {
            Console.WriteLine(employee.FirstName + " personeli eklendi");
        }

        public void Delete(User employee)
        {
            Console.WriteLine(employee.FirstName + " personeli kayıtlardan silindi");
        }

        public void Update(User employee)
        {
            Console.WriteLine(employee.FirstName + " personel bilgileri güncellendi");
        }
    }
}
