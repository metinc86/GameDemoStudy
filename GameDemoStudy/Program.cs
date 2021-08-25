using System;

namespace GameDemoStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "METİN",
                LastName = "CANIMOĞLU",
                BirthYear = 1986,
                Money = 125,
                NationalityId = 12345
            });
            CampaignManager campaignManager = new CampaignManager();

            Campaing campaing = campaignManager.Add(1, "Black Friday", 5.0 );
            campaignManager.Update(campaing, 10.0);
            Game game = new Game{ Id = 1, Name = "Call Of Duty", CategoryId = 5, Price = 150, Version = "2.0" };
            OrderManager orderManager = new OrderManager(campaignManager);
            orderManager.Buy(game);
        }
    }
}
