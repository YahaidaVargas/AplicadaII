using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace PersonaTelefonos
{
    public partial class DetalleTel : System.Web.UI.Page
    {
        PersonTel pt = new PersonTel();
        protected void Page_Load(object sender, EventArgs e)
        {
            string idPer = Request.QueryString["id"];
            DtTelefonos.DataSource = pt.Listado("*","PersonaId="+idPer);
            DtTelefonos.DataBind();
        }


    }
}