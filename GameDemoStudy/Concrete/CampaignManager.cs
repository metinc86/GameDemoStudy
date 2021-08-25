using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoStudy
{
    class CampaignManager : ICampaingService
    {
        public Campaing Add(int id, string name, double discountRate)
        {
            Console.WriteLine(name + " added! ");
            return new Campaing
            {
                Id = id,
                Name = name,
                DiscountRate = discountRate
            };
        }

        public void Delete(Campaing campaign)
        {
            Console.WriteLine(campaign.Name + " deleted! ");
        }

        public Campaing Update(Campaing campaign, double discountRate)
        {
            Console.WriteLine(campaign.Name + " Updated! ");
            campaign.DiscountRate = discountRate;
            return campaign;
            
        }
    }
}
