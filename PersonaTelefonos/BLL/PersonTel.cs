using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
 public  class PersonTel: ClaseMaestra       
    {

        ConexionDb conexion = new ConexionDb();
        public int idPersonTel { get; set; }
        public int PersonaId { get; set; }
        public string TipoTelefono { get; set; }
        public string Telefono { get; set; }

        public PersonTel()
        {
            PersonaId = 0;
            TipoTelefono = null;
            Telefono = null;

        }
        public override bool Insertar()
        {
            string consulta = string.Format("insert into PersonTel(PersonaId,TipoTelefono,Telefono) values({0},'{1}','{2}')", PersonaId, TipoTelefono, Telefono);
            return(conexion.EjecutarDB(consulta));

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

        public override DataTable Listado(string Campos="*", string Condicion="1=1", string Orden="desc")
        {
            return conexion.BuscarDb("Select" + Campos + "from PersonTel where " + Condicion+ " order by IdPersonTel "+ Orden );
        }
    }
    }

