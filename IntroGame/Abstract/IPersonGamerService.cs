using IntroGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroGame.Abstract
{
    public interface IPersonGamerService
    {
        void Add(PersonGamer personGamer);
        void Update(PersonGamer personGamer);
        void Delete(PersonGamer personGamer);
    }
}
