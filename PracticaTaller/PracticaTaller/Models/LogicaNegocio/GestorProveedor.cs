using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticaTaller.Models.AccesoDatos;
using PracticaTaller.Models.LogicaNegocio;

namespace PracticaTaller.Models.LogicaNegocio
{
    public class GestorProveedor
    {
        RepositorioProveedor repoProveedor = new RepositorioProveedor();
        public List<Proveedor> Listar()
        {
            return repoProveedor.Listar();
        }


        public void Guardar(Proveedor proveedor)
        {
            repoProveedor.Guardar(proveedor);
        }

        internal void Eliminar(int id)
        {
            repoProveedor.Eliminar(id);
        }

        internal Proveedor ObtenerPorId(int id)
        {
            return repoProveedor.ObtenerPorId(id);
        }

        internal void Modificar(Proveedor proveedor)
        {
            repoProveedor.Modificar(proveedor);
        }
    }
}