using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Juego
    {
        private Jugador jugador1;
        private Jugador jugador2;
        private List<Bitmon> bitmons;

        public Juego()
        {
            //bitmons.Add(new Bitmon ...) para cada bitmon
        }
        private void CrearJugadores()
        {
            Console.WriteLine("Jugador 1");
            string nombre1 = Menu.PedirNombre();
            jugador1 = new Jugador(nombre1);
            Console.WriteLine("Jugador 2");
            string nombre2 = Menu.PedirNombre();
            jugador2 = new Jugador(nombre2);
        }
        private void DesplegarBitmons()
        {
            foreach (Bitmon bitmon in bitmons)
            {
                //Console.WriteLine(bitmon.getnombre());   hacer getters
            }
        }
        private void AsignarBitmons()
        {
            Console.WriteLine("Jugador 1");
            jugador1.AgregarBitmon(0, bitmons[Menu.ElegirBitmon() - 1]);
            Console.WriteLine("Jugador 2");
            jugador2.AgregarBitmon(0, bitmons[Menu.ElegirBitmon() - 1]);
            Console.WriteLine("Jugador 2");
            jugador2.AgregarBitmon(1, bitmons[Menu.ElegirBitmon() - 1]);
            Console.WriteLine("Jugador 1");
            jugador1.AgregarBitmon(1, bitmons[Menu.ElegirBitmon() - 1]);
            Console.WriteLine("Jugador 1");
            jugador1.AgregarBitmon(2, bitmons[Menu.ElegirBitmon() - 1]);
            Console.WriteLine("Jugador 2");
            jugador2.AgregarBitmon(2, bitmons[Menu.ElegirBitmon() - 1]);
        }

    }
}
