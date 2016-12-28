using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.ViewModels
{
    public class ProveedorViewModels
    {
        public int id_proveedor { get; set; }
        public string razon_social { get; set; }
        public Nullable<decimal> cuit { get; set; }
        public string direccion { get; set; }
    }
}