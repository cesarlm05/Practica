using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaTaller.Models.LogicaNegocio;
using PracticaTaller.ViewModels;
using PracticaTaller.Models.AccesoDatos;

namespace PracticaTaller.Controllers
{
    public class VentasController : Controller
    {
        GestorVenta gestorVentas = new GestorVenta();
        // GET: Ventas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            var listaVenta = gestorVentas.Listar();
            return View(listaVenta);
        }

        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult Guardar(VentaViewModels venta)
        {
            var nuevaVenta = new Venta
            {
                Fecha = venta.Fecha,
                Total = venta.Total
            };
            gestorVentas.Guardar(nuevaVenta);
            return RedirectToAction("Listar");
        }
    }
}