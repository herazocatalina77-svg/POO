using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_clase_7_abril
{
    internal class Libro
    {
        public string titulo = "";
        string autor;
        bool estadoDisponibilidad = true;
        void CambiarDisponibilidadLibro(bool disponible) //método que retorna un booleano, este método se usa después de prestar el libro
        {
            disponible = false;
            Console.Clear();
            Console.WriteLine("Libro prestado exitosamente");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

        }
        void VerDisponibilidad(bool disponible)
        {
            if (disponible == false)
            {
                Console.WriteLine("El libro no está disponible");
            }
            else
            {
                Console.WriteLine("El libro está disponible");
            }
        }
    }
}
