using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data;
using System.Data.SqlClient;

namespace OOPStok
{
    public partial class PersonelEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (IsPostBack == false)
           {
                SqlCommand komut = new SqlCommand("SELECT * FROM TBL_DEPARTMAN", Baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataValueField = "DEPARTMANİD";
                DropDownList1.DataTextField = "DEPARTMANAD";
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Personelad = TextBox1.Text;
            ent.Personelsoyad = TextBox2.Text;
            ent.Personeldepartman = byte.Parse(DropDownList1.SelectedValue);
            ent.Personelmaas = decimal.Parse(TextBox3.Text);
            BLLPersonel.BLLPersonelEkle(ent);
            Response.Redirect("Personel.Aspx");

        }
    }
}