using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.PantallaInicio();
            Juego juego = new Juego();
            juego.CrearJugadores();
            juego.DesplegarBitmons();
            juego.AsignarBitmons();
            Console.ReadKey(true);

        }
    }
}
