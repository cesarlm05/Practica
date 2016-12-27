using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.ViewModels
{
    public partial class ProductoViewModel
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> stock { get; set; }
        public Nullable<decimal> precio { get; set; }
    }
}