using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoC.Servicios
{
    /// <summary>
    /// Interfaz del menu
    /// irodhan -> 22/01/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y obtiene la opcion seleccionada por el usuario
        /// irodhan -> 22/01/2024
        /// </summary>
        /// <returns>Devuelve la opcion seleccionada por el usuario</returns>
        public int mostrarMenuYSeleccion();
        /// <summary>
        /// Metodo que muestra el menu del cliente y obtiene la opcion seleccionada por el usuario
        /// irodhan -> 22/01/2024
        /// </summary>
        /// <returns>Devuelve la opcion seleccionada por el usuario</returns>
        public int mostrarMenuYSeleccionCliente();
        /// <summary>
        /// Metodo que muestra el menu del empleado y obtiene la opcion seleccionada por el usuario
        /// irodhan -> 22/01/2024
        /// </summary>
        /// <returns>Devuelve la opcion seleccionada por el usuario</returns>
        public int mostrarMenuYSeleccionEmpleado();
    }
}
