using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoStudy
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
