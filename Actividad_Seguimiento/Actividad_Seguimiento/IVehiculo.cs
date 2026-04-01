using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_Seguimiento
{
    internal interface IVehiculo
    {
        virtual void Run()
        {
            Console.WriteLine("Corriendo");
        }
    }
}
