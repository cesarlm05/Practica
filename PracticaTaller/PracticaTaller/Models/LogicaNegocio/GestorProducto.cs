using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticaTaller.Models.AccesoDatos;
using PracticaTaller.Models.LogicaNegocio;

namespace PracticaTaller.Models.LogicaNegocio
{
    
    public class GestorProducto
    {
        RepositorioProducto repoProducto = new RepositorioProducto();
        public List<Producto> Listar()
        {
            return repoProducto.Listar();
        }


        public void Guardar(Producto producto)
        {
            repoProducto.Guardar(producto);
        }

        internal void Eliminar(int id)
        {
            repoProducto.Eliminar(id);
        }

        internal Producto ObtenerPorId(int id)
        {
            return repoProducto.ObtenerPorId(id);
        }

        internal void Modificar(Producto producto)
        {
            repoProducto.Modificar(producto);
        }
    }
}