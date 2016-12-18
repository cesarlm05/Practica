using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaTaller.Models.LogicaNegocio;

namespace PracticaTaller.Controllers
{
    public class ClientesController : Controller
    {
        GestorCliente gestorCliente = new GestorCliente();
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            var listaClientes = gestorCliente.Listar();
            return View(listaClientes);
        }

        public ActionResult Crear()
        {
            return View();
        }

    }
}