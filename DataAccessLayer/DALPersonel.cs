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
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("DEPARTMANLİST", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Personelid = int.Parse(dr["PERSONELID"].ToString());
                ent.Personelad = dr["PERSONELAD"].ToString();
                ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
              //  ent.Personeldepartman = byte.Parse(dr["PERSONELDEPARTMAN"].ToString());
                ent.Personeldep = dr["DEPARTMANAD"].ToString();
                ent.Fotograf = dr["PERSONELFOTOGRAF"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONEL (PERSONELAD,PERSONELSOYAD,PERSONELDEPARTMAN,PERSONELMAAS) VALUES (@P1,@P2,@P3,@P4)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Personelad);
            komut.Parameters.AddWithValue("@P2", p.Personelsoyad);
            komut.Parameters.AddWithValue("@P3", p.Personeldepartman);
            komut.Parameters.AddWithValue("@P4", p.Personelmaas);       
            return komut.ExecuteNonQuery();
        }
    }
}
