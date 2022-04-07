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
    public class DALDepartman
    {
        public static List<EntityDepartman>DepartmanListesi()
        {
            List<EntityDepartman> degerler = new List<EntityDepartman>();
            SqlCommand komut = new SqlCommand("Select * From TBL_DEPARTMAN",Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                EntityDepartman ent = new EntityDepartman();
                ent.Departmanid = byte.Parse(dr["DEPARTMANİD"].ToString());
                ent.Departmanad = dr["DEPARTMANAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int DepartmanEkle(EntityDepartman p)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBL_DEPARTMAN (DEPARTMANAD) values (@p1)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1",p.Departmanad);
            return komut1.ExecuteNonQuery();
        }

    }
}
