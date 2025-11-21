using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase1AppConsola
{
    // 0 referencias
    internal class Program
    {
        // 0 referencias
        static void Main(string[] args)
        {
            //Declararación de variables
            string nombre;
            string edad;
            string fechaNac;
            string carrera;

            Console.WriteLine("Bienvenidos a UMI/Universidad Coppel");
            Console.WriteLine("\nIngresa los datos que se te piden: ");
            Console.WriteLine("Nombre completo: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Edad: ");
            edad = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento (DD/MM/AAAA): ");
            fechaNac = Console.ReadLine();
            Console.WriteLine("Carrera a la que desea ingresar: ");
            carrera = Console.ReadLine();

            Console.WriteLine("\n\nGracias " + nombre + " por formar parte de UMI/Universidad Coppel. \nBienvenido a la carrera de " + carrera + ".");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Fecha de nacimiento: " + fechaNac);
            Console.WriteLine("Carrera asignada: " + carrera);
            Console.WriteLine("\n\n\n\n\n");

            Console.ReadLine();
        }
    }
}