using IntroGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroGame.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public float GamePrice { get; set; }
    }
}
