using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
   public class BLLSATIS
    {
        public static List<EntitySatis> Satıslistesi()
        {
            return DALSatıs.SatisListesi();
        }
    }
}
