using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Semana_7
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
            confirmado = true;
            Console.WriteLine("CONFIRMADO YAY");
            //presione cualquier letra para continuar
        }
        public static void AgregarProducto(string producto)
        {

        }
    }
}
