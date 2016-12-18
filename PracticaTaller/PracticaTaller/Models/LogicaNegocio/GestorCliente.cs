using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticaTaller.Models.AccesoDatos;

namespace PracticaTaller.Models.LogicaNegocio
{
    public class GestorCliente
    {
        RepositorioCliente repoCLientes = new RepositorioCliente();

        public List<Cliente> Listar()
        {
            return repoCLientes.Listar();
        }


        public void Guardar(Cliente cliente)
        {
            repoCLientes.Guardar(cliente);
        }

        internal void Eliminar(int id)
        {
            repoCLientes.Eliminar(id);
        }

        internal Cliente ObtenerPorId(int id)
        {
            return repoCLientes.ObtenerPorId(id);
        }

        internal void Modificar(Cliente cliente)
        {
            repoCLientes.Modificar(cliente);
        }

        internal List<Cliente> Buscar(string parametroBusqueda)
        {
            return repoCLientes.Buscar(parametroBusqueda);
        }
    }
}