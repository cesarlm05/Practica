using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.ViewModels
{
    public class ClienteViewModel
    {
        public int idCliente { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> nro_dni { get; set; }
        public string Apellido { get; set; }
    }
}