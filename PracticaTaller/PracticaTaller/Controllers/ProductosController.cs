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
    public class ProductosController : Controller
    {
        GestorProducto gestorProductos = new GestorProducto();
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            var listaProductos = gestorProductos.Listar();
            return View(listaProductos);
        }

        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult Guardar(ProductoViewModel producto)
        {
            var nuevoProducto = new Producto
            {
                nombre = producto.nombre,
                descripcion = producto.descripcion,
                stock = producto.stock,
                precio = producto.precio                               
            };

            gestorProductos.Guardar(nuevoProducto);
            return RedirectToAction("Listar");
        }

        public ActionResult Modificar(int id)
        {
            var productoModificar = gestorProductos.ObtenerPorId(id);
            return View(productoModificar);
        }

        public ActionResult GuardarModificacion(Producto producto)
        {
            gestorProductos.Modificar(producto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            gestorProductos.Eliminar(id);
            return RedirectToAction("Listar");
        }
    }
}