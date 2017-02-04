using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.ViewModels
{
    public class VentaViewModels
    {
        public int idVenta { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}