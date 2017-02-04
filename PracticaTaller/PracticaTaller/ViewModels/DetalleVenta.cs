using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.ViewModels
{
    public class DetalleVentaViewModels
    {
        public int idDetalleVenta { get; set; }
        public Nullable<int> idVenta { get; set; }
        public Nullable<int> idProducto { get; set; }
    }
}