using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
    
namespace OOPStok
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDepartman> DepList = DALDepartman.DepartmanListesi();
            Repeater1.DataSource = DepList;
            Repeater1.DataBind();
        }
    }
}