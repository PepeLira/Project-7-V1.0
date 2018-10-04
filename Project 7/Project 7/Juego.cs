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
        private List<Bitmon> bitmons = new List<Bitmon>();

        public Juego()
        {
            bitmons.Add(new RobinWilliams());
            bitmons.Add(new Brad_Pitt ());
            bitmons.Add(new SigourneyWeaver());
            bitmons.Add(new JimCarrey());
            bitmons.Add(new TomHanks());
            bitmons.Add(new Johnny_Deep());
            bitmons.Add(new Natalie_Portman());
            bitmons.Add(new Vin_Diesel());
            bitmons.Add(new Leonardo_Dicaprio());
            bitmons.Add(new JackNicholson());
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
        public void DesplegarBitmons()
        {
            foreach (Bitmon bitmon in bitmons)
            {
                Console.WriteLine(bitmon.nombre);
                Console.WriteLine(bitmon.hp);
                Console.WriteLine(bitmon.Estamina);
                Console.WriteLine(bitmon.ataque);
                Console.WriteLine(bitmon.defensa);
                Console.WriteLine("======================================");
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
