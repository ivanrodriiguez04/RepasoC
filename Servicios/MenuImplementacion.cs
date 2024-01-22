using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoC.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz del menu
    /// irodhan -> 22/01/2024 
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion = 0;
            Console.WriteLine("0. Cerrar App");
            Console.WriteLine("1. Version empleado");
            Console.WriteLine("2. Version cliente");
            Console.WriteLine("Introduzca la opcion deseada:");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public int mostrarMenuYSeleccionCliente()
        {
            int opcion = 0;
            Console.WriteLine("0. Cerrar App");
            Console.WriteLine("1. Registrarse");
            Console.WriteLine("2. Login");
            Console.WriteLine("Introduzca la opcion deseada:");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public int mostrarMenuYSeleccionEmpleado()
        {
            int opcion = 0;
            Console.WriteLine("0. Cerrar App");
            Console.WriteLine("1. Validar cliente");
            Console.WriteLine("2. Borrar cliente");
            Console.WriteLine("3. Mostrar cliente");
            Console.WriteLine("Introduzca la opcion deseada:");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
