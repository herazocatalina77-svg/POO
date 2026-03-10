using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO
{
    internal class Canciones
    {
        static public string[] songs = new string[100];
        static public int added = 0;
        static public string whereF = @"C:\Users\Acer\Desktop\POO\Nueva carpeta\File.txt";
        static public string whereL = @"C:\Users\Acer\Desktop\POO\Nueva carpeta\File.txt";

        static public void AgregarCanciones()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre de la canción");
            string name = Console.ReadLine();
            for (int i = 0; i < songs.Length; i++)
            {
                while (songs[i] == name)
                {
                    Console.WriteLine("ERROR - Canción repetida");
                    Console.WriteLine("Ingrese el nombre de la canción");
                    name = Console.ReadLine();
                }
            }
            songs[added] = name;
            added++;
            using (StreamWriter mylogs = File.AppendText(whereF))
            {
                mylogs.WriteLine(name);
                mylogs.Close();
            }
            Console.WriteLine("Presione cualquier tecla para ir al menú de canciones");
            Console.ReadKey();
            Menu.MainMenu();
        }
        static public void BorrarCanciones()
        {
            Console.Clear();
            Console.WriteLine("Qué canción desea eliminar?");
            for (int i = 0; i < added; i++)
            {
                Console.WriteLine(songs[i] + " (" + i + ")");
            }
            int name = int.Parse(Console.ReadLine());
            songs = songs.Where((source, index) => index != name).ToArray();
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
            Console.ReadKey();
            Menu.MainMenu();
        }

        static public void MostrarCanciones()
        {
            Console.Clear();
            Console.WriteLine("Qué desea hacer?\nAscendente (1)\nDescendente (2)\nMostrar la lista externa (3)");
            int answerT = int.Parse(Console.ReadLine());
            if (answerT == 1) for (int i = 0; i < added; i++) Console.WriteLine(songs[i]);
            if (answerT == 2) for (int i = added; i >= 0; i--) Console.WriteLine(songs[i]);
            if (answerT == 3)
            {
                using (StreamReader mylogs = new StreamReader(whereL))
                {
                    while (mylogs.Peek() >= 0)
                    {
                        Console.WriteLine(mylogs.ReadLine());
                    }
                    mylogs.Close();
                }
            }
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
            Console.ReadKey();
            Menu.MainMenu();
        }

        static public void RenombrarCanciones()
        {
            Console.Clear();
            Console.WriteLine("Qué canción desea renombrar?");
            for (int i = 0; i < added; i++)
            {
                Console.WriteLine(songs[i] + " (" + i + ")");
            }
            int name = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo nombre");
            songs[name] = Console.ReadLine();
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
            Console.ReadKey();
            Menu.MainMenu();
        }
    }
}
