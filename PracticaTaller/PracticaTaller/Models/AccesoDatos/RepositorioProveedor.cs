using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.Models.AccesoDatos
{
    public class RepositorioProveedor
    {
        TallerDB_Entities baseDatos = new TallerDB_Entities();

        public List<Proveedor> Listar()
        {
            return baseDatos.Proveedor.ToList();
        }

        public void Guardar(Proveedor proveedor)
        {
            baseDatos.Proveedor.Add(proveedor);
            baseDatos.SaveChanges();
        }

        internal void Eliminar(int id)
        {
            var proveedor = baseDatos.Proveedor.FirstOrDefault(c => c.id_proveedor == id);
            baseDatos.Proveedor.Remove(proveedor);
            baseDatos.SaveChanges();
        }

        internal Proveedor ObtenerPorId(int id)
        {
            return baseDatos.Proveedor.FirstOrDefault(c => c.id_proveedor == id);
        }

        internal void Modificar(Proveedor proveedor)
        {
            var proveedorParaModificar = baseDatos.Proveedor.FirstOrDefault(c => c.id_proveedor == proveedor.id_proveedor);

            proveedorParaModificar.razon_social = proveedor.razon_social;
            proveedorParaModificar.cuit = proveedor.cuit;
            proveedorParaModificar.direccion = proveedor.direccion;

            baseDatos.SaveChanges();
        }
    }
}