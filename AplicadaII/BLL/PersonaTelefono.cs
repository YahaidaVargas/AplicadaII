using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class PersonaTelefono
    {
        private ConexYaha conexion = new ConexYaha();





        public int Id { get; set; }
        public int PersonaId { get; set; }
        public string TipoTelefono { get; set; }
        public string Telefono { get; set; }
      


        public bool BuscarId(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public bool Insertar()
        {

            string consulta = string.Format("insert into PersonasTelefonos (PersonasId,TipoTelefono,Telefono) values('{0}','{1}','{2}');", PersonaId, TipoTelefono,Telefono);
            return (conexion.EjecutarDB(consulta));

            
        }


        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return conexion.BuscarDb("Select " + campos + " from PersonasTelefonos where " + Filtro);
        }

        public bool Modificar()
        {
            throw new NotImplementedException();
        }
    }


}

