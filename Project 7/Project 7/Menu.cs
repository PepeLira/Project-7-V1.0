using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Menu
    {
        static void PantallaInicio()
        {
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        public static string PedirNombre()
        {
            Console.WriteLine("Introduce tu nombre");
            string nombre = Console.ReadLine();
            return nombre;
        }

        public static int ElegirBitmon()
        {
            Console.WriteLine("Elije un bitmon");
            int eleccion = Console.Read();
            return eleccion;
        }
    }
}
