using RepasoC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoC.Servicios
{
    internal interface OperacionalesEmpleadoInterfaz
    {
        /// <summary>
        /// Metodo que valida a un nuevo cliente
        /// irodhan -> 22/01/2024
        /// </summary>
        /// <param name="listaClienteAntigua"></param>
        public void validarCliente(List<ClienteDto> listaClienteAntigua);
       /// <summary>
       /// metodo que borra a un cliente
       /// irodhan -> 22/01/2024
       /// </summary>
       /// <param name="listaClienteAntigua"></param>
        public void borrarCliente(List<ClienteDto> listaClienteAntigua);
       /// <summary>
       /// Metodo que muestra a todos los clientes
       /// irodhan -> 22/01/2024
       /// </summary>
       /// <param name="listaClienteAntigua"></param>
        public void mostrarClientes(List<ClienteDto> listaClienteAntigua);
    }
}
