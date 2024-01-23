using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RepasoC.Dtos
{
    internal class ClienteDto
    {
        //Atributos
        private long idCliente;
        private string dniCliente = "aaaaa";
        private string nombreCliente = "aaaaa";
        private string apellido1 = "aaaaa";
        private string apellido2 = "aaaaa";
        private string nombreCompletoCliente="aaaaa";
        private string emailCliente = "aaaaa";
        private string contraseñaCliente = "aaaaa";
        private bool esValido=false;

        //Getters & Setters
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string ContraseñaCliente { get => contraseñaCliente; set => contraseñaCliente = value; }
        public bool EsValido { get => esValido; set => esValido = value; }

        //Constructores
        public ClienteDto(long idCliente, string dniCliente, string nombreCliente, string apellido1, string apellido2, string nombreCompletoCliente, string emailCliente, string contraseñaCliente, bool esValido)
        {
            this.idCliente = idCliente;
            this.dniCliente = dniCliente;
            this.nombreCliente = nombreCliente;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.nombreCompletoCliente = apellido1 + " "+apellido2+", "+nombreCliente;
            this.emailCliente = emailCliente;
            this.contraseñaCliente = contraseñaCliente;
            this.esValido = esValido;
        }

        public ClienteDto()
        {
        }

        //ToString
        override
        public string ToString() 
        {
            string concatenacion = 
                "\nDNI: "+this.dniCliente+
                "\nNOMBRE: "+this.nombreCompletoCliente+
                "\n ESTADO VALIDACIÓN: "+this.esValido+
                "\n%%%%%%%%%%";

            return concatenacion;
        }

    }
}
