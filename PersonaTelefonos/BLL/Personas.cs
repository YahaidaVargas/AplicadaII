using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Personas: ClaseMaestra
    {

        private ConexionDb conexion = new ConexionDb();

        public int PersonasId { get; set; }
        public string Nombres { get; set; }
        public string Sexo { get; set; }


        public Personas()
        {
            PersonasId = 0;
            Nombres = null;
            Sexo = null;
        }

        public override bool Insertar()
        {
            string consulta = string.Format("insert into Personas (Nombres,Sexo) values('{0}','{1}') SELECT @@IDENTITY", Nombres, Sexo);
            // return conexion.EjecutarDB(consulta); 

            PersonasId = Convert.ToInt32(conexion.ObtenerValorDb(consulta).ToString());
            return PersonasId > 0;
                
            


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

        public override DataTable Listado(string Campos = "*", string Condicion = "1=1", string Orden = "desc")
        {
            return conexion.BuscarDb("Select" + Campos + "from Personas where " + Condicion + " order by PersonasId " + Orden);
        }
    }
    }
