using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Semana_7_version_2026
{
    internal class Empleado
    {
        static public bool despachado = false;
        public static void DespacharPedido(bool despachado)
        {
            Console.Clear();
            despachado = true;
            Console.WriteLine("Pedido despachado");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
