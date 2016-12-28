using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaTaller.Models.AccesoDatos;
using PracticaTaller.Models.LogicaNegocio;
using PracticaTaller.ViewModels;

namespace PracticaTaller.Controllers
{
    public class ProveedoresController : Controller
    {
        GestorProveedor gestorProveedor = new GestorProveedor();
        // GET: Proveedores
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            var listaProveedores = gestorProveedor.Listar();
            return View(listaProveedores);
        }

        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult Guardar(ProveedorViewModels proveedor)
        {
            var nuevoProveedor = new Proveedor
            {
                razon_social = proveedor.razon_social,
                cuit = proveedor.cuit,
                direccion = proveedor.direccion
            };
            gestorProveedor.Guardar(nuevoProveedor);
            return RedirectToAction("Listar");
        }

        public ActionResult Modificar(int id)
        {
            var proveedorModificar = gestorProveedor.ObtenerPorId(id);
            return View(proveedorModificar);
        }

        public ActionResult GuardarModificacion(Proveedor proveedor)
        {
            gestorProveedor.Modificar(proveedor);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            gestorProveedor.Eliminar(id);
            return RedirectToAction("Listar");
        }
    }
}