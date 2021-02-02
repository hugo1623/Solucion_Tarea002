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
                $"Tengo : {cliente1.Telefono.Count} Telefonos \n");

            Console.WriteLine("************ CLIENTE  2 ************");

            var cliente2 = new Cliente("Kyra", "Luis01", "Rodriguez01");
            cliente2.Telefono.Add("000211");
            cliente2.Telefono.Add("021548");
            cliente2.Telefono.Add("126254");
            Console.WriteLine(
                $"Nombre: {cliente2.Nombre} \n" +
                $"Apellido Paterno : {cliente2.ApellidoPaterno} \n" +
                $"Apellido Materno : { cliente2.ApellidoMaterno} \n" +
                $"Tengo : {cliente2.Telefono.Count} Telefonos \n");

            Console.WriteLine("Apellido Materno : " + cliente2.ApellidoMaterno + "\n");

            Console.WriteLine("************ CLIENTE  3 ************ ");

            var cliente3 = new Cliente("16170022", fecha);
            DateTime fecha1 = new DateTime(2000, 10, 26, 8, 10, 5);
            cliente3.FechaNacimiento = fecha1;
            cliente3.Telefono.Add("788542");
            cliente3.Telefono.Add("956321");
            cliente3.Telefono.Add("423215");
            cliente3.Telefono.Add("164829");
            Console.WriteLine(
                $"Dni : {cliente3.Dni } \n" +
                $"Fecha de Nacimiento : {cliente3.FechaNacimiento} \n" +
                $"Tengo : {cliente3.Telefono.Count} Telefonos \n");
           



        }
    }
}
