using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDEPARTMAN
    {
        public static List<EntityDepartman> BLLDepartmanListele()
        {
            return DALDepartman.DepartmanListesi();
        }
        public static int BLLDepartmanEkle(EntityDepartman p)
        {
            if(p.Departmanad != null && p.Departmanad!="")
            {
                return DALDepartman.DepartmanEkle(p);
            }
            return -1;
        }
    }
}
