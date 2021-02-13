using IntroGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroGame.Entities
{
    public class PersonGamer : IEntity
    {
        public int Id { get; set; }
        public Int64 NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
    }
}
