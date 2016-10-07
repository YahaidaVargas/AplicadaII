using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class PersonaTEL
    {

        public string Telefono { get; set; }
        public TiposTelefonos TipoTelefono{ get; set; }

        public string Tipo
        {

            get { return TipoTelefono.ToString(); }
        }

    public PersonaTEL(TiposTelefonos tipo, string telefono) {
            this.TipoTelefono = tipo;
            this.Telefono = Telefono;
    }

    }
}
