using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Semana_7
{
    internal class Empleado:Usuario
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
