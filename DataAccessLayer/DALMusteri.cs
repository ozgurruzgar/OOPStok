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
    public class DALMusteri
    {
        public static List<EntityMusteri> MusteriListesi()
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("Select * From TBL_MUSTERI",Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.Musteriid = Convert.ToInt16(dr["MUSTERID"]);
                ent.Musteriad = dr["MUSTERİAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int MusteriEkle(EntityMusteri p)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBL_MUSTERI (MUSTERİAD,MUSTERISOYAD) values (@P1,@P2)", Baglanti.bgl);
            if(komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@P1",p.Musteriad);
            komut1.Parameters.AddWithValue("@P2",p.Musterisoyad);
            return komut1.ExecuteNonQuery();
        }

        public static bool MusteriSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete From TBL_MUSTERI WHERE MUSTERID=@P1",Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1",p);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<EntityMusteri> MusteriGetir(int id)
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("Select * From TBL_MUSTERI where MUSTERID=@P1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1",id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
             //   ent.Musteriid = Convert.ToInt16(dr["MUSTERID"]);
                ent.Musteriad = dr["MUSTERİAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool MusteriGuncelle(EntityMusteri p)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_MUSTERI SET MUSTERİAD=@P1,MUSTERISOYAD=@P2 WHERE MUSTERID=@P3",Baglanti.bgl);
            if(komut.Connection.State!= ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1",p.Musteriad);
            komut.Parameters.AddWithValue("@P2",p.Musterisoyad);
            komut.Parameters.AddWithValue("@P3",p.Musteriid);
            return komut.ExecuteNonQuery()> 0;
        }
    }
}
