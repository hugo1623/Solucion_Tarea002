using System;
using System.Collections.Generic;


namespace Tarea002
{
   public class Cliente
    {
        public Cliente() 
        {
            Telefono = new List<string>();
        }

        public Cliente(string nombre, string apellidoPaterno, string apellidoMaterno) : this()
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
        }
        public Cliente(string dni, DateTime fechaNacimiento) :this()
        {
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
        }

        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public List<string> Telefono { get; set; }


    }
}
