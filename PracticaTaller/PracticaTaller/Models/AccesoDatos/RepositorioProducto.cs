using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.Models.AccesoDatos
{
    public class RepositorioProducto
    {
        TallerDB_Entities baseDatos = new TallerDB_Entities();

        public List<Producto> Listar()
        {
            return baseDatos.Producto.ToList();
        }

        public void Guardar(Producto producto)
        {
            baseDatos.Producto.Add(producto);
            baseDatos.SaveChanges();
        }

        internal void Eliminar(int id)
        {
            var producto = baseDatos.Producto.FirstOrDefault(c => c.id_producto == id);
            baseDatos.Producto.Remove(producto);
            baseDatos.SaveChanges();
        }

        internal Producto ObtenerPorId(int id)
        {
            return baseDatos.Producto.FirstOrDefault(c => c.id_producto == id);
        }

        internal void Modificar(Producto producto)
        {
            var productoParaModificar = baseDatos.Producto.FirstOrDefault(c => c.id_producto == producto.id_producto);

            productoParaModificar.nombre = producto.nombre;
            productoParaModificar.descripcion = producto.descripcion;
            productoParaModificar.stock = producto.stock;
            productoParaModificar.precio = producto.precio;

            baseDatos.SaveChanges();
        }
    }
}