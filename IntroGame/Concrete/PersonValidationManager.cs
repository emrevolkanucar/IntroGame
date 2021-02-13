using IntroGame.Abstract;
using IntroGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroGame.Concrete
{
    public class PersonValidationManager : IPersonValidationService
    {
        public bool Validation(PersonGamer personGamer)
        {
            if (personGamer.FirstName == "Emre" && personGamer.LastName == "Ucar" && personGamer.NationalityId == 123456789 && personGamer.BirthYear == 1988)
            {
                return true;
            }
            else
            {
                return false;
            };
        }
    }
}
