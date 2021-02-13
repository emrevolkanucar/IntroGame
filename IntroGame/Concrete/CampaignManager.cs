using IntroGame.Abstract;
using IntroGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroGame.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya " + campaign.CampaignName + " eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya " + campaign.CampaignName + " silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya " + campaign.CampaignName + " güncellendi.");
        }
    }
}
