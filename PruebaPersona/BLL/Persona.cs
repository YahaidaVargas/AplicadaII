using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
 public   class Persona:ClaseMaestra
    

    {
        public int PersonaId { get; set; }
        public string Nombres{ get; set; }
        public string Sexo { get; set; }

        public List<PersonaTEL> Telefonos { get; set; }


        public Persona()
        {

            this.PersonaId = 0;
            this.Nombres = "";
            this.Sexo = "";
            Telefonos = new List<PersonaTEL>();
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            int retorno = 0;
            Object identity;

            try
            {

                identity = conexion.ObtenerDatos("insert into PersonTel(PersonaId, Nombre,Sexo) Values('" + this.PersonaId + "','" + this.Nombres + "','" + this.Sexo + "')SELECT @@identity");

                int.TryParse(identity.ToString(), out retorno);
                this.PersonaId = retorno;

                foreach (PersonaTEL item in this.Telefonos)
                {

                    conexion.Ejecutar(string.Format("Inser into PersonTelefono(PersonaId,Tipo,Telefono)values{0},'{1}','{2}'", retorno, (int)item.TipoTelefono, item.Telefono));
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno > 0;
            
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
