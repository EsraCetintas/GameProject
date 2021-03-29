using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncunun " + game.GameName + " satıldı...");
        }
        public void CampaignSale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + "  " + gamer.LastName + " " + " adlı oyuncunun " + game.GameName + " yüzde " + campaign.CampaignDiscout + "  indirimle satıldı.");
        }
    }
}
