using System;
namespace Trabajo_clase_7_abril
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> ListaUsuario = new List<Usuario>();
            List<Libro> ListaLibro = new List<Libro>();
            void AbrirMenu()
            {
                Console.WriteLine("Bienvenido a la base de datos del club de lectura");
                Console.WriteLine("Ingrese la opción según lo que desea hacer");
                Console.WriteLine("1. Agregar libro al club");
                Console.WriteLine("2. Agregar usuario al club");
                Console.WriteLine("3. Buscar disponibilidad de un libro");
                Console.WriteLine("4. Ver la cantidad de libros prestados por usuario");
                Console.WriteLine("5. Ver lista de libros en el club");
            }
            void ActualizarFechaActual()
            {
                string diaActual;
                string mesActual;
                string year;
                Console.WriteLine("Ingrese el día de hoy");
                //leer dato
                Console.WriteLine("Ingrese el mes actual");
                //Leer dato
                Console.WriteLine("Ingrese el año actual");
                //leer dato
            }
            void AgregarLibro()
            {

            }
            void AgregarUsuario()
            {

            }
            void BuscarLibro()
            {

            }
            void BuscarUsuario()
            {

            }
            void MostrarLista()
            {

            }
            void PreguntarDisponibilidadLibro()
            {

            }
        }
    }
}