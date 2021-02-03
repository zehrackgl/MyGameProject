using System;
using System.Collections.Generic;
using System.Text;
using MyGameProject.Abstract;
using MyGameProject.Entities;

namespace MyGameProject.Concrete
{
    public class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Zehra" && gamer.LastName == "Açıkgül" && gamer.GamerId == 123456 && gamer.IdentityNumber == 12345678910
               && gamer.BirthYear == 2001)
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
