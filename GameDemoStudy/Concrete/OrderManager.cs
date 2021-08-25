using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoStudy
{
    class OrderManager : IOrderService
    {
        CampaignManager _campaignManager;

        public OrderManager(CampaignManager campaignManager)
        {
            _campaignManager = campaignManager;
        }

        public void Buy(Game game)
        {
            Console.WriteLine(game.Name + " is ordered!");
        }
    }
}
