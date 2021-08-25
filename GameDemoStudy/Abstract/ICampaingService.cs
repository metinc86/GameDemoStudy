using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoStudy
{
    interface ICampaingService
    {
        Campaing Add(int Id, string Name, double DiscountRate);
        Campaing Update(Campaing campaign, double DiscountRate);
        void Delete(Campaing campaign);
    }
}
