using IntroGame.Abstract;
using IntroGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroGame.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Add(Sales sales)
        {
            if (sales.campaign != null)
            {
                Console.WriteLine(sales.personGamer.FirstName + " " + sales.personGamer.LastName + " " + sales.game.GameName + " adlı oyunu " + ((sales.game.GamePrice * (100 - sales.campaign.Discount)) / 100) + " TL'ye satın aldı.");
            } else
            {
                Console.WriteLine(sales.personGamer.FirstName + " " + sales.personGamer.LastName + " " + sales.game.GameName + " adlı oyunu " + sales.game.GamePrice + " TL'ye satın aldı.");
            }
            
        }

        public void Delete(Sales sales)
        {
            Console.WriteLine("");
        }

        public void Update(Sales sales)
        {
            Console.WriteLine("");
        }
    }
}
