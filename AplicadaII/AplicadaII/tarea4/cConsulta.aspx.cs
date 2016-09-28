using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AplicadaII.tarea4
{
    public partial class cConsulta : System.Web.UI.Page    
   {
        Persona Pers = new Persona();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            gvConsulta.DataSource = Pers.Listar();
            gvConsulta.DataBind();

        }

        protected void gvConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected row using the SelectedRow property.
            GridViewRow row = gvConsulta.SelectedRow;
            id = row.Cells[0].Text;


            

            Response.Redirect("~/cDetalle.aspx?id=" + id);
        }

        protected void gvConsulta_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {


       
           // Response.Redirect("~/cDetalle.aspx?id="+id);
        }

       
    }
}