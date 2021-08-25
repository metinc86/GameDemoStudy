using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoStudy
{
    public class Campaing : ICampaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountRate { get; set; }
    }
}
