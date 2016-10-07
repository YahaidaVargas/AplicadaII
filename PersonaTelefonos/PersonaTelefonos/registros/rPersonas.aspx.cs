using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace PersonaTelefonos
{
    public partial class rPersonas : System.Web.UI.Page
    {
        Personas Per = new Personas();
        PersonTel pertel = new PersonTel();
        
        protected void Page_Load(object sender, EventArgs e)
        {
        

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            int PerId;
            Per.Nombres = TxtNombre.Text;
            Per.Sexo = DDsexo.SelectedValue;
            Per.Insertar();
            PerId = Per.PersonasId;


            pertel.PersonaId = PerId;
            pertel.TipoTelefono = DdtipoTel.SelectedValue;
            pertel.Telefono = TxtTel.Text;
            pertel.Insertar();
            Response.Redirect("~/consultas/cConsulta.aspx");

        }

    }
}