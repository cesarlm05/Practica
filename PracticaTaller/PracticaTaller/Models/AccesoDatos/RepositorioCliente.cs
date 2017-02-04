using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticaTaller.Models.AccesoDatos;


namespace PracticaTaller.Models.AccesoDatos
{
    public class RepositorioCliente
    {
        TallerDB_Entities baseDatos = new TallerDB_Entities();

        public List<Cliente> Listar()
        {
            return baseDatos.Cliente.ToList();
        }

        public void Guardar(Cliente cliente)
        {
            baseDatos.Cliente.Add(cliente);
            baseDatos.SaveChanges();
        }

        internal void Eliminar(int id)
        {
            var cliente = baseDatos.Cliente.FirstOrDefault(c => c.idCliente == id);
            baseDatos.Cliente.Remove(cliente);
            baseDatos.SaveChanges();
        }

        internal Cliente ObtenerPorId(int id)
        {
            return baseDatos.Cliente.FirstOrDefault(c => c.idCliente == id);
        }

        internal void Modificar(Cliente cliente)
        {
            var clienteParaModificar = baseDatos.Cliente.FirstOrDefault(c => c.idCliente == cliente.idCliente);

            clienteParaModificar.Apellido = cliente.Apellido;
            clienteParaModificar.Nombre = cliente.Nombre;
            clienteParaModificar.nro_dni = cliente.nro_dni;

            baseDatos.SaveChanges();
        }

        internal List<Cliente> Buscar(string parametroBusqueda)
        {
            var clienteEncontrado = baseDatos.Cliente.Where
              (p => p.Apellido.Contains(parametroBusqueda) || p.Nombre.Contains(parametroBusqueda) || Convert.ToString(p.nro_dni).Contains(parametroBusqueda));
            return clienteEncontrado.ToList();
        }

    }
}