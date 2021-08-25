using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoStudy
{
    interface IGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public int CategoryId{ get; set; }
        public double Price { get; set; }
    }
}
