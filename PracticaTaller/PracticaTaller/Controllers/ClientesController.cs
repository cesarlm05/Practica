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

        public ActionResult Guardar(ClienteViewModel cliente)
        {
            var nuevoCliente = new Cliente
            {
                Apellido = cliente.Apellido,
                Nombre = cliente.Nombre,
                nro_dni = cliente.nro_dni
            };

            gestorCliente.Guardar(nuevoCliente);
            return RedirectToAction("Listar");
        }

        public ActionResult Modificar(int id)
        {
            var clienteModificar = gestorCliente.ObtenerPorId(id);
            return View(clienteModificar);
        }

        public ActionResult GuardarModificacion(Cliente cliente)
        {
            gestorCliente.Modificar(cliente);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            gestorCliente.Eliminar(id);
            return RedirectToAction("Listar");
        }

    }
}