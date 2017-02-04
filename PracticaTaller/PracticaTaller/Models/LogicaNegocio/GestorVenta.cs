using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticaTaller.Models.AccesoDatos;

namespace PracticaTaller.Models.LogicaNegocio
{
    public class GestorVenta
    {
        RepositorioVenta repoVenta = new RepositorioVenta();

        public List<Venta> Listar()
        {
            return repoVenta.Listar();
        }

        public void Guardar(Venta venta)
        {
            repoVenta.Guardar(venta);
        }
    }
}