using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace PersonaTelefonos
{
    public partial class cConsulta : System.Web.UI.Page
    {
        Personas persona = new Personas();
        protected void Page_Load(object sender, EventArgs e)
        {
            GvConsult.DataSource = persona.Listado();
            GvConsult.DataBind();


        }
    }
}