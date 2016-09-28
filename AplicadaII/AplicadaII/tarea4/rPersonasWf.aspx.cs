using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using System.Collections;

namespace AplicadaII.tarea4
{
    public partial class rPersonasWf : System.Web.UI.Page
    {
        Persona Pers = new Persona();
        PersonaTelefono perTel = new PersonaTelefono();

        protected void Page_Load(object sender, EventArgs e)
        {
            RefrescaTabla();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Pers.Nombre = txtNombre.Text;
            Pers.Sexo = cbSexo.SelectedValue;
            Pers.Insertar();
            int IdPersona = Pers.PersonaId;


            perTel.PersonaId = IdPersona;
            perTel.TipoTelefono = tipoTel.SelectedValue;
            perTel.Telefono = txtTelefono.Text;


         if(perTel.Insertar())
            {
                limpia();
                RefrescaTabla();
            }
            Console.Write(IdPersona);



        }

        void limpia() {
            txtNombre.Text = string.Empty;
            cbSexo.SelectedIndex = 0;
            tipoTel.SelectedIndex=0;
            txtTelefono.Text = string.Empty;
            perTel.PersonaId = 0;

        }


        void RefrescaTabla()
        {
            Persona per = new Persona();
         gvPersona.DataSource = per.Listar();
            gvPersona.DataBind();
        }
            
                

        protected void gvPersona_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            txtNombre.Text = e.Values[2].ToString();
        }

        protected void gvPersona_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvPersona_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            txtNombre.Text = e.NewValues.Count.ToString();
        }

        protected void gvPersona_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string tipo = Tbusqueda.SelectedValue;

            Persona person = new Persona();

            string busqueda = txtBuscar.Text;

            switch (tipo)
            {

                case "id":
                   
                    gvPersona.DataSource = person.Listar("*", "PersonasId= " + busqueda);
                    gvPersona.DataBind();
                    break;

                case "Nombre":
                    gvPersona.DataSource = person.Listar("*", "Nombres like '%" + busqueda+"%'");
                    gvPersona.DataBind();

                    break;

                case "Telefono":

                    break;
                default:
                    break;
            }

        }
    }
}