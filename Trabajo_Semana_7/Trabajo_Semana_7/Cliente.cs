using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Semana_7
{
    internal class Cliente:Usuario
    {
        public static bool pedidoRealizado = false;
        public static bool RealizarPedido()
        {
            Console.Clear();
            pedidoRealizado = true;
            Console.WriteLine("Pedido realizado éxitosamente");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            return pedidoRealizado;
        }
    }
}
