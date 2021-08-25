using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoStudy
{
    interface ICampaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountRate { get; set; }
    }
}
