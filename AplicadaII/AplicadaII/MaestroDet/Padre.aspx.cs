using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AplicadaII.MaestroDet
{
    public partial class Padre : System.Web.UI.Page

        
    {

        Persona person = new Persona();

        protected void Page_Load(object sender, EventArgs e)
        {

            GridView1.DataSource = person.Listar();
            GridView1.DataBind();
        }
    }
}