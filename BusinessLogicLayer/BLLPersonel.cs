using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLPersonel
    {
        public static List<EntityPersonel> BLLMusteriListele()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int BLLPersonelEkle(EntityPersonel p)
        {
            if(p.Personelad!="" && p.Personelsoyad!="" && p.Personeldepartman!=0)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }
    }
}
