using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("Sisteme "+entity.CampaignName+" kampanyası kayıt edildi");
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine("Sistemden " + entity.CampaignName + " kampanyası silindi");
        }

        public void Update(Campaign entity)
        {
            Console.WriteLine("Sistemde " + entity.CampaignName + " kampanyası güncellendi");
        }
    }
}
