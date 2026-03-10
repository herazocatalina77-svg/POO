using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Semana_7
{
    internal class Cliente:Usuario
    //Agregado autonómamente :)
    {
        public static bool pedidoRealizado = false;
        public static bool RealizarPedido()
        {
            //Agregado autonómamente :)
            pedidoRealizado = true;
            Console.WriteLine("Pedido realizado éxitosamente");
            return pedidoRealizado;
        }
    }
}
