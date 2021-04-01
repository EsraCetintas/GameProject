using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer entity)
        {
            if (_gamerCheckService.CheckIfRealPerson(entity))
            {
                Console.WriteLine("Sisteme " + entity.FirstName + " " + entity.LastName + " isimli oyuncu eklendi");
            }
            else
            {
                Console.WriteLine("Geçerli bir kişi değildir.");
            }
        }

        public void Delete(Gamer entity)
        {
            Console.WriteLine("Sistemden "+entity.FirstName+" "+entity.LastName+" isimli oyuncu silindi");
        }

        public void Update(Gamer entity)
        {
            Console.WriteLine("Sistemde " + entity.FirstName + " " + entity.LastName + " isimli oyuncu bilgileri güncellendi");
        }
    }
}
