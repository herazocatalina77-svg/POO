using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Seguimiento
{
    internal class Coche:IVehiculo
    {
        string conductor = "";
        void AddDriver()
        {
            Console.WriteLine("Añadiendo conductor");
        }
        void IVehiculo.Run()
        {
            //Implementación de la interfaz vehículo-realización
        }
    }
}
