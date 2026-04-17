using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_clase_7_abril
{
    internal class Usuario
    {
        public string nombre;
        public string cedula;
        public int tiempoPrestado; //Medido en días
        public string fecha;
        double multa = 0;
        public void PrestarLibro()
        {
            string libroPrestar;
            Console.WriteLine("Ingrese el nombre del libro que desea prestar");
            libroPrestar = Console.ReadLine() ?? "";
            //leer dato
            //se busca el libro
            //si existe: ¿está disponible para prestar?
            //Si está disponible, se presta
            //Si no está disponible: el libro no está disponible, espere a que esté disponible o busque otro libro para prestar
            //Si no existe: el libro no existe en el inventario
        }
        void MostrarTiempoRestanteLibroPrestado()
        {

        }
        void DevolverLibroDespuesdeFecha() //método que retorna un booleano
        {

        }
    }
}
