using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Semana_7_version_2026
{
    internal class Pedido
    {
        public static string fecha;
        public static string status;
        public static double total;
        public static double descuento;
        public static bool despachado = false;
        public static bool confirmado = false;

        public static void ConfirmarPedido()
        {
            Console.Clear();
            confirmado = true;
            Console.WriteLine("CONFIRMADO YAY");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            //presione cualquier letra para continuar
        }
        public static void IngresarProducto(string nombre, string marca, string tipo, List<string> infoProducto)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre de su pedido");
            nombre = Console.ReadLine() ?? "valor por defecto";
            infoProducto.Add(nombre);
            Console.WriteLine("Ingrese la marca de su pedido");
            marca = Console.ReadLine() ?? "valor por defecto";
            infoProducto.Add(marca);
            Console.WriteLine("Ingrese el tipo de pedido");
            tipo = Console.ReadLine() ?? "valor por defecto";
            infoProducto.Add(tipo);
            Console.Clear();
            Console.WriteLine("Producto ingresado, presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
