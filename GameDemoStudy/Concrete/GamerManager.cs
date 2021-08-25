using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoStudy
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Gamer " + gamer.FirstName + " is added! ");
            }
            else
            {
                Console.WriteLine(" User invalid! Gamer is not added! ");
            }           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.FirstName + " is updated! ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is deleted! ");
        }
    }
}
