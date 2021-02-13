using IntroGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroGame.Abstract
{
    public interface IPersonValidationService
    {
        bool Validation(PersonGamer personGamer);
    }
}
