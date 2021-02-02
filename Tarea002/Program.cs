using System;

namespace Tarea002
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente1 = new Cliente();
            cliente1.Nombre = "Hugo";
            cliente1.ApellidoPaterno = "Luis";
            cliente1.ApellidoMaterno = "Rodríguez";
            DateTime fecha = new DateTime(1994, 09, 16, 18, 0, 5);
            cliente1.FechaNacimiento = fecha;
            cliente1.Dni = "72539928";
            cliente1.Edad = 100;
            cliente1.Telefono.Add("0002133");
            cliente1.Telefono.Add("115552");

            Console.WriteLine("************ CLIENTE  1 ************");
            Console.WriteLine(
                $"Nombre : {cliente1.Nombre} \n" +
                $"Apellido Paterno : {cliente1.ApellidoPaterno} \n" +
                $"Apellido Materno : {cliente1.ApellidoMaterno} \n" +
                $"Fecha de Nacimiento : {cliente1.FechaNacimiento} \n" +
                $"Dni : {cliente1.Dni} \n" +
                $"Edad :{cliente1.Edad} \n" +
                $"Tengo : {cliente1.Telefono.Count} Telefono \n");

            Console.WriteLine("************ CLIENTE  2 ************");
            var cliente2 = new Cliente("Kyra", "Luis01", "Rodriguez01");
            Console.WriteLine("Nombre:" + cliente2.Nombre);
            Console.WriteLine("Apellido Paterno :" + cliente2.ApellidoPaterno);
            Console.WriteLine("Apellido Materno :" + cliente2.ApellidoMaterno);

        }
    }
}
