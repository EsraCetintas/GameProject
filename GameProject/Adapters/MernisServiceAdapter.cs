using GameProject.Abstract;
using GameProject.Entities;
using GameProject.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient();
            return kPSPublicSoapClient.TCKimlikNoDogrula(Convert.ToInt64(gamer.NationalyId),
                gamer.FirstName.ToUpper(),gamer.LastName.ToUpper(),gamer.DateOfBirth.Year);
        }
    }
}
