using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoStudy
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1986 && gamer.FirstName == "METİN" &&
                gamer.LastName == "CANIMOĞLU" && gamer.NationalityId == 12345)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
