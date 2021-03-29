using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
   public interface IGamerService<T> : IEntityRepository<T>
        where T:class,IEntity,new()
    {

    }
}
