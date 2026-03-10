using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO
{
    internal class Menu
    {
        static public void MainMenu()
        {                              
            //MENU
            int options = 0;
            Console.Clear();
            Console.WriteLine("\nQué desea hacer?");
            Console.WriteLine("Agregar nueva canción (1)");
            Console.WriteLine("Eliminar una canción (2)");
            Console.WriteLine("Mostrar canciones (3)");
            Console.WriteLine("Cambiar nombre a canción (4)");
            options = Int32.Parse(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Canciones.AgregarCanciones();
                    break;
                case 2:
                    Canciones.BorrarCanciones();
                    break;
                case 3:
                    Canciones.MostrarCanciones();
                    break;
                case 4:
                    Canciones.RenombrarCanciones();
                    break;
                default:
                    break;
            }
        }
    }
}
