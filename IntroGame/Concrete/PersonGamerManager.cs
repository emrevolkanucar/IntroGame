using IntroGame.Abstract;
using IntroGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroGame.Concrete
{
    class PersonGamerManager : IPersonGamerService
    {
        IPersonValidationService _personValidationService;

        public PersonGamerManager(IPersonValidationService personValidationService)
        {
            _personValidationService = personValidationService;
        }

        public void Add(PersonGamer personGamer)
        {
            if (_personValidationService.Validation(personGamer))
            {
                Console.WriteLine("Oyuncu " + personGamer.FirstName + " kaydedildi.");
            }
            else
            {
                Console.WriteLine("Oyuncu bilgileri mernis'ten teyit edilemedi.");
            }
        }

        public void Delete(PersonGamer personGamer)
        {
            Console.WriteLine("Oyuncu " + personGamer.FirstName + " silindi.");
        }

        public void Update(PersonGamer personGamer)
        {
            if (_personValidationService.Validation(personGamer))
            {
                Console.WriteLine("Oyuncu " + personGamer.FirstName + " güncellendi.");
            }
            else
            {
                Console.WriteLine("Oyuncu bilgileri mernis'ten teyit edilemedi.");
            }
        }
    }
}
