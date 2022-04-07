using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class DALUrun
    {
        public static List<EntityUrun> Urunlistesi()
        {
            List<EntityUrun> degerler = new List<EntityUrun>();
            SqlCommand komut = new SqlCommand("Select * From TBL_URUN", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                EntityUrun ent = new EntityUrun();
                ent.Urunid = byte.Parse(dr["URUNID"].ToString());
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Urunfiyat = decimal.Parse(dr["URUNFIYAT"].ToString());
                if(dr["URUNADET"] != DBNull.Value)
                {
                    ent.Urunadet = (int)dr["URUNADET"];
                }
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;

        }
        public static int UrunEkle(EntityUrun p)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_URUN (URUNAD,URUNFIYAT,URUNADET) VALUES (@P1,@P2,@P3)",Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1",p.Urunad);
            komut.Parameters.AddWithValue("@P2",p.Urunfiyat);
            komut.Parameters.AddWithValue("@P3",p.Urunadet);
            return komut.ExecuteNonQuery();
        }
    }
}
