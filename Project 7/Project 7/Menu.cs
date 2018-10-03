using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Menu
    {
        public static void PantallaInicio()
        {
            Console.CursorLeft = (Console.WindowWidth /2 - "BOLLYWOOD SHOWDOWN".Length/2);
            Console.CursorTop = (Console.WindowHeight / 4);
            Console.Write("BOLLYWOOD SHOWDOWN");//titulo tentativo
            Console.CursorLeft = (Console.WindowWidth /2 - "Presione cualquier tecla para continuar".Length/2);
            Console.CursorTop = (Console.WindowHeight *3 / 4);
            Console.Write("Presione cualquier tecla para continuar");
            Console.ReadKey(true);
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
            while (true)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int age))
                {
                    Console.WriteLine("{0} is not an integer", input);
                    // Whatever
                }
                else
                {
                    return age;
                }
            }
        }
    }
}
