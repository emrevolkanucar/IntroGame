using IntroGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroGame.Entities
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public PersonGamer personGamer { get; set; }
        public Game game { get; set; }
        public Campaign campaign { get; set; }
        public float Price { get; set; }
    }
}
