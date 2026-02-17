using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17Feb
{
    internal class Perro:Animal //Clase que hereda de Animal, es decir, subclase Perro de la clase animal
    {
        string owner;
        void Comer()
        {

        }
        void Hacer_Sonido() //Polimorfismo, ya que en la clase animal hay un método que tiene la misma función
        {
            Console.WriteLine("Guau");
        }
    }
}
