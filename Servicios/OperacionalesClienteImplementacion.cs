using RepasoC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoC.Servicios
{
    /// <summary>
    /// Clase que inmplementa a la interfaz de las operaciones del cliente
    /// irodhan -> 22/01/2024
    /// </summary>
    internal class OperacionalesClienteImplementacion : OperacionalesClienteInterfaz
    {
        public void loginCliente(List<ClienteDto> listaClientesAntigua)
        {
            throw new NotImplementedException();
        }

        public void registrarCliente(List<ClienteDto> listaClientesAntigua)
        {
            ClienteDto nuevoCliente = crearCliente();
            listaClientesAntigua.Add(nuevoCliente);
        }
        private ClienteDto crearCliente() 
        {
            ClienteDto nuevoCliente = new ClienteDto();

            return nuevoCliente;
        }
    }
}
