using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class Persona
    {
        private ConexYaha conexion = new ConexYaha();





        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
      


        public bool BuscarId(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public bool Insertar()
        {

            string consulta = string.Format("insert into Personas (Nombres,Sexo) values('{0}','{1}') SELECT @@IDENTITY;", Nombre, Sexo);
            PersonaId=Convert.ToInt32 (conexion.ObtenerValorDb(consulta).ToString());

            return this.PersonaId > 0;
        }


        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            throw new NotImplementedException();
        }

        public bool Modificar()
        {
            throw new NotImplementedException();
        }
    }


}

