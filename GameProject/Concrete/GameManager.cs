using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game entity)
        {
            Console.WriteLine(entity.GameName+" isimli oyun sisteme eklendi");
        }

        public void Delete(Game entity)
        {
            Console.WriteLine(entity.GameName + " isimli oyun sistemden silindi");
        }

        public void Update(Game entity)
        {
            Console.WriteLine(entity.GameName + " isimli oyun sistemde güncellendi");
        }
    }
}
