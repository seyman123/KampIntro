namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "İbrahim";
            gamer1.LastName = "Seyman";
            gamer1.BirthYear = 2001;
            gamer1.IdentityNumber = 29629454810;

            Employee employee1 = new Employee();
            employee1.Id = 2;
            employee1.FirstName = "Engin";
            employee1.LastName = "Demiroğ";
            employee1.BirthYear = 1985;
            employee1.IdentityNumber = 12345678910;
            employee1.Salary = 5000;

            IUserService gamerManager = new GamerManager(new NewEStateValidationManager());
            gamerManager.Add(gamer1);

            IUserService employeeManager = new EmployeeManager();
            employeeManager.Add(employee1);

            IOrderService orderManager = new OrderManager();
            orderManager.Add(new Game() { GameName = "Euro Truck Simulator", Id = 1, Type = "Simulator"});

        }
    }
}