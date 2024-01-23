using RepasoC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoC.Servicios
{
    /// <summary>
    /// Interfaz de las operaciones del cliente
    /// irodhan -> 22/01/2024
    /// </summary>
    internal interface OperacionalesClienteInterfaz
    {
        /// <summary>
        /// Metodo que registra un nuevo cliente
        /// irodhan -> 22/01/2024
        /// </summary>
        /// <param name="listaClientesAntigua"></param>
        public void registrarCliente(List<ClienteDto> listaClientesAntigua);
        /// <summary>
        /// Metodo que hace el login de un cliente ya validado
        /// irodhan -> 22/01/2024
        /// </summary>
        /// <param name="listaClientesAntigua"></param>
        public void loginCliente(List<ClienteDto> listaClientesAntigua);
    }
}
