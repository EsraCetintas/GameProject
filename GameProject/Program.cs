using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());

            Gamer gamer = new Gamer();

            // kendi bilgilerinizi girerek deneyebilirsiniz...
            gamer.DateOfBirth = new DateTime(1999, 2, 17);
            gamer.FirstName = "esra";
            gamer.LastName = "çetintaş";
            gamer.NationalyId = "11111111111";
            gamer.Mail = "esra.cetintas@outlook.com.tr";

            gamerManager.Add(gamer);


            Game game = new Game();
            game.GameId = 123456;
            game.GameName = "Uzay Oyunu";
            game.GamePrice = 19.99f;

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Campaign campaign = new Campaign();
            campaign.CampaignId = 135790;
            campaign.CampaignName = "Son fırsatlar";
            campaign.CampaignDiscout = 20;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            campaign.CampaignDiscout = 30;
            campaignManager.Update(campaign);

            SaleManager sale = new SaleManager();
            sale.Sale(gamer, game);
            sale.CampaignSale(gamer, game, campaign);
            Console.ReadKey();
        }
    }
}
