using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //NombreClase.Metodo();
            Console.WriteLine("HOLI, este es un programa para ingresar canciones :)");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Canciones.AgregarCanciones();

        }
    }
}