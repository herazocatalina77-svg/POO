using System;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using Trabajo_Semana_7_version_2026;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Trabajo_semana_7
{
    internal class Program
    {
        //Main
        static void Main(string[] args)
        {
            bool despachado = Empleado.despachado;
            string nombre = Usuario.nombre;
            string marca = Producto.marca;
            string tipo = Producto.tipo;
            List<string> lista = Producto.infoProducto;
            AbrirMenu(despachado, nombre, marca, tipo, lista);
        }
        public static void AbrirMenu(bool despachado, string nombre, string marca, string tipo, List<string> infoProducto)
        {
            Console.Clear();
            string opcion = "";
            Console.WriteLine("1.Ingresar usuario");
            Console.WriteLine("2.Realizar pedido-Cliente");
            Console.WriteLine("3.Despachar pedido-empleado");
            Console.WriteLine("4.Ingresar Producto");
            Console.WriteLine("5.Confirmar pedido");
            Console.WriteLine("6.Salir del programa");
            opcion = Console.ReadLine() ?? "valor por defecto";
            switch (opcion)
            {
                case "1":
                    {
                        Usuario.IngresarInfoUsuario();
                        AbrirMenu(despachado, nombre, marca, tipo, infoProducto);
                        break;
                    }
                case "2":
                    {
                        Cliente.RealizarPedido();
                        AbrirMenu(despachado, nombre, marca, tipo, infoProducto);
                        break;
                    }
                case "3":
                    {
                        Empleado.DespacharPedido(despachado);
                        AbrirMenu(despachado, nombre, marca, tipo, infoProducto);

                        break;
                    }
                case "4":
                    {
                        Pedido.IngresarProducto(nombre, marca, tipo, infoProducto);
                        AbrirMenu(despachado, nombre, marca, tipo, infoProducto);
                        break;
                    }
                case "5":
                    {
                        Pedido.ConfirmarPedido();
                        AbrirMenu(despachado, nombre, marca, tipo, infoProducto);
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("Byeee");
                        break;
                    }
            }
        }
    }
}