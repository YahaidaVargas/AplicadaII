using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AplicadaII.tarea4
{
    public partial class rPersonasWf : System.Web.UI.Page
    {
        Persona Pers = new Persona();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Pers.Nombre = txtNombre.Text;
            Pers.Sexo = cbSexo.SelectedValue;
            Pers.Insertar();
            int IdPersona = Pers.PersonaId;
            Console.Write(IdPersona);

        }
    }
}