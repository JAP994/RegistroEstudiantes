using System;

namespace Registro
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Registro de alumnos");
            Console.WriteLine("Ingresar primer nombre");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Ingresar segundo nombre");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Ingresar primer apellido");
            string apellido1 = Console.ReadLine();
            Console.WriteLine("Ingresar segundo apellido");
            string apellido2 = Console.ReadLine();
            var estudiante = new Estudiante(nombre1, nombre2, apellido1, apellido2);
            Console.Write("........................................ \n");
            Console.WriteLine("Ingresar Asignatura a la que pertenece.");
            string asignatura = Console.ReadLine();
            var materia = new Asignatura(asignatura);
            Console.Write("........................................ \n");
            Console.WriteLine("Ingresar Cuidad a la que pertenece.");
            string ciudad = Console.ReadLine();
            var ciudadPerteneciente = new Ciudad(ciudad);
            Console.Write("........................................ \n");
            Console.WriteLine("Ingresar fecha de nacimiento.");
            Console.WriteLine("Ingresar día.");
            string dia = Console.ReadLine();
            Console.WriteLine("Ingresar mes.");
            string mes = Console.ReadLine();
            Console.WriteLine("Ingresar año.");
            string anio = Console.ReadLine();
            var fech = new Fecha(dia, mes, anio);
            Console.Write("........................................ \n");
            Console.Write($"Se ha registrado con éxito. \n{ estudiante.imprimirTodo() }\n");
            Console.Write($"Su asignatura es: { materia.obtenerAsignatura() } \n");
            Console.Write($"La Cuidad es : { ciudadPerteneciente.obtenerCiudad() } \n");
            DateTime fechaHoy = DateTime.Today;
            Console.Write($"Fecha de nacimiento :{ fech.obtenerFecha() }  \n");
            Console.Write("........................................ \n");
            Console.Write($"Fecha de registro : { fechaHoy } \n");
            Console.Write("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}