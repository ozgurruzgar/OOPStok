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
    public class DALSatıs
    {
        public static List<EntitySatis> SatisListesi()
    {
            List<EntitySatis> degerler = new List<EntitySatis>();
            SqlCommand komut = new SqlCommand("SATISLAR", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                EntitySatis ent = new EntitySatis();
                ent.Satisid = int.Parse(dr["SATISID"].ToString());
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Personelad = dr["PERSONEL"].ToString();
              //  ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Musteriad = dr["MÜŞTERİ"].ToString();
                ent.Fiyat = decimal.Parse(dr["TUTAR"].ToString());
             //   ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
    }
    }
}
