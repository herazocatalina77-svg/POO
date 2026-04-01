using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Semana_7_version_2026
{
    internal class Cliente
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
