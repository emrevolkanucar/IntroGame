using IntroGame.Concrete;
using IntroGame.Entities;
using System;

namespace IntroGame
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonGamerManager personGamerManager = new PersonGamerManager(new PersonValidationManager());

            // Gamer 1
            PersonGamer personGamer1 = new PersonGamer { Id = 1, FirstName = "Emre", LastName = "Ucar", BirthYear = 1988, NationalityId = 123456789 };
            // Gamer 2
            PersonGamer personGamer2 = new PersonGamer { Id = 1, FirstName = "Gizem", LastName = "Ucar", BirthYear = 1992, NationalityId = 987654321 };


            // Add
            personGamerManager.Add(personGamer1);
            personGamerManager.Add(personGamer2);

            // Update
            personGamer1.BirthYear = 1987;
            personGamerManager.Update(personGamer1);

            // Delete
            personGamerManager.Delete(personGamer1);



            // Games
            GameManager gameManager = new GameManager();

            Game game1 = new Game { Id = 1, GameName = "Warfare", GamePrice = 299 };
            Game game2 = new Game { Id = 2, GameName = "Fortnite", GamePrice = 10 };
            Game game3 = new Game { Id = 3, GameName = "Red Alert", GamePrice = 9 };
            Game game4 = new Game { Id = 4, GameName = "Valheim", GamePrice = 32 };

            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.Add(game4);

            // Campaign
            CampaignManager campaignManager = new CampaignManager();

            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "14 Şubat Sevgililer Günü İndirimi", Discount = 10 };
            Campaign campaign2 = new Campaign { Id = 1, CampaignName = "Hafta Sonu İndirimi", Discount = 15 };
            Campaign campaign3 = new Campaign { Id = 1, CampaignName = "KDV İndirimi", Discount = 18 };

            // Add
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign3);

            // Update
            campaign1.Discount = 25;
            campaignManager.Update(campaign1);

            // Delete
            campaignManager.Delete(campaign1);

            // Sales
            SalesManager salesManager = new SalesManager();

            Sales sale1 = new Sales { Id = 1, personGamer = personGamer1, game = game1, campaign = campaign1 };
            Sales sale2 = new Sales { Id = 2, personGamer = personGamer1, game = game2 };

            salesManager.Add(sale1);
            salesManager.Add(sale2);



        }
    }
}
