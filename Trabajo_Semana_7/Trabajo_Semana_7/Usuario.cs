using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Semana_7
{
    internal class Usuario
    {
        public static string nombre = "";
        public static string email = "";
        public static string sexo = "";
        public static string direccion = "";
        public static string ciudad = "";
        public static int edad;
        public static int id;
        public static List <string> info1 = new List<string>();
        public static List<int> info2 = new List<int>();
        //Métodos
        public static void IngresarInfoUsuario()
        {
            Console.Clear();
            //lista string
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            info1.Add(nombre);
            Console.WriteLine("Ingrese su email");
            email = Console.ReadLine();
            info1.Add(email);
            Console.WriteLine("Ingrese su dirección");
            direccion = Console.ReadLine();
            info1.Add(direccion);
            Console.WriteLine("Ingrese su ciudad");
            ciudad = Console.ReadLine();
            info1.Add(ciudad);
            //Lista int 
            Console.WriteLine("Ingrese su edad");
            edad = Int32.Parse(Console.ReadLine());
            info2.Add(edad);
            Console.WriteLine("Ingrese su id");
            id = Int32.Parse(Console.ReadLine());
            info2.Add (id);
            Console.Clear();
            Console.WriteLine("Usuario ingresado, presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
