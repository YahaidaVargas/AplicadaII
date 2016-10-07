using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BLL;
  
namespace BLL
{
    public abstract class ClaseMaestra
    {

        public abstract bool Insertar();

        public abstract bool Editar();

        public abstract bool Eliminar();

        public abstract bool Buscar(int IdBuscado);

        public abstract DataTable Listado(string Campos, string Condicion, string Orden);


    }
}
