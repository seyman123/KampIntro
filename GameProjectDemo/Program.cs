namespace GameProjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "İbrahim";
            gamer1.LastName = "Seyman";
            gamer1.DateOfYear = 2004;
            gamer1.NationalityId = "29629454810";

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "Esma";
            gamer2.LastName = "Seyman";
            gamer2.DateOfYear = 1966;
            gamer2.NationalityId = "123456789";

            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "Euro Truc Simulator";
            game1.Price = 30;
            game1.Type = "Simulator";

            BaseGamerManager childGamerManager = new ChildGamerManager(new GamerCheckManager());
            BaseGamerManager teenGamerManager = new TeenGamerManager();
            childGamerManager.Save(gamer1);
            teenGamerManager.Save(gamer2);

            IGameService gameManager = new GameManager();
            gameManager.Sell(gamer1, game1);

            GameCampaign gameCampaing1= new GameCampaign();
            gameCampaing1.DiscountRate = 15;

            GameCampaignManager gameCampaingManager = new GameCampaignManager();
            gameCampaingManager.Add(game1, gameCampaing1);
            gameCampaingManager.Delete(game1);


        }
    }
}