using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.Models.AccesoDatos
{
    public class RepositorioVenta
    {
        TallerDB_Entities baseDatos = new TallerDB_Entities();

        public List<Venta> Listar()
        {
            return baseDatos.Venta.ToList();
        }

        public void Guardar(Venta venta)
        {
            baseDatos.Venta.Add(venta);
            baseDatos.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var venta = baseDatos.Venta.FirstOrDefault(c => c.idVenta == id);
            baseDatos.Venta.Remove(venta);
            baseDatos.SaveChanges();
        }

        public Venta ObtenerPorId(int id)
        {
            return baseDatos.Venta.FirstOrDefault(c => c.idVenta == id);
        }

        public void Modificar(Venta venta)
        {
            var ventaParaModificar = baseDatos.Venta.FirstOrDefault(c => c.idVenta == venta.idVenta);

            ventaParaModificar.DetalleVenta = venta.DetalleVenta;
            ventaParaModificar.Fecha = venta.Fecha;
            ventaParaModificar.Total = venta.Total;

            baseDatos.SaveChanges();
        }
    }
}