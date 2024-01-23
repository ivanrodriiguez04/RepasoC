using RepasoC.Dtos;
using RepasoC.Servicios;
using System.ComponentModel.Design;

namespace RepasoC.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 22/01/2024 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 22/01/2024 
        /// </summary>
        static void Main(string[] args)
        {
            //Listas
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            //Objetos
            MenuInterfaz mI = new MenuImplementacion();
            OperacionalesEmpleadoInterfaz oE= new OperacionalesEmpleadoImplementacion();
            OperacionalesClienteInterfaz oC = new OperacionalesClienteImplementacion();
            //Atributos
            bool cerrarMenu=false;
            int opcionSeleccionada = 0;
            int opcionEmpleado = 0;
            int opcionCliente = 0;

            while(!cerrarMenu) 
            {
                opcionSeleccionada=mI.mostrarMenuYSeleccion();
                switch (opcionSeleccionada) 
                { 
                    case 0:
                        Console.WriteLine("[INFO] - Se va a cerrar la aplicacion");
                        cerrarMenu=true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion de los empleados");
                        opcionEmpleado=mI.mostrarMenuYSeleccionEmpleado();
                        switch (opcionEmpleado) 
                        {
                            case 0:
                                Console.WriteLine("[INFO] - Se va a volver al menu principal");
                                break;
                            case 1:
                                Console.WriteLine("[INFO] - Ha seleccionado la opcion validar cliente");
                                oE.validarCliente(listaClientes);
                                break; 
                            case 2:
                                Console.WriteLine("[INFO] - Ha seleccionado la opcion borrar cliente");
                                oE.borrarCliente(listaClientes);
                                break; 
                            case 3:
                                Console.WriteLine("[INFO] - Ha seleccionado la opcion mostrar cliente");
                                oE.mostrarClientes(listaClientes);
                                break;
                            default:
                                Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                                break;
                        }
                        break; 
                    case 2:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion de los clientes");
                        opcionCliente = mI.mostrarMenuYSeleccionCliente();
                        switch (opcionCliente)
                        {
                            case 0:
                                Console.WriteLine("[INFO] - Se va a volver al menu principal");
                                break;
                            case 1:
                                Console.WriteLine("[INFO] - Ha seleccionado la opcion registro");
                                oC.registrarCliente(listaClientes);
                                break;
                            case 2:
                                Console.WriteLine("[INFO] - Ha seleccionado la opcion de login");
                                oC.loginCliente(listaClientes);
                                break;
                            default:
                                Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                        break;
                }
            }

        }
    }
}
