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
            bitmons.Add(new RobinWilliams() );
            bitmons.Add(new Brad_Pitt());
            bitmons.Add(new SigourneyWeaver());
            bitmons.Add(new JimCarrey());
            bitmons.Add(new TomHanks());
            bitmons.Add(new Johnny_Deep());
            bitmons.Add(new Natalie_Portman());
            bitmons.Add(new Vin_Diesel());
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
        public int MultiplicadorTipo(string tipo1, string tipo2)
        {
            if ((tipo1 == "Historico" && tipo2 == "Aventura")|| (tipo1 == "Historico" && tipo2 == "Comedia")|| (tipo1 == "Suspenso" && tipo2 == "Historico") || (tipo1 == "Suspenso" && tipo2 == "Accion") || (tipo1 == "Aventura" && tipo2 == "Aventura") || (tipo1 == "Aventura" && tipo2 == "Comedia") || (tipo1 == "Aventura" && tipo2 == "Romance") || (tipo1 == "Comedia" && tipo2 == "Accion") || (tipo1 == "Comedia" && tipo2 == "Romance") || (tipo1 == "Comedia" && tipo2 == "Muerto") || (tipo1 == "Accion" && tipo2 == "Comedia") || (tipo1 == "Drama" && tipo2 == "Aventura") || (tipo1 == "Drama" && tipo2 == "Drama") || (tipo1 == "Romance" && tipo2 == "Suspenso") || (tipo1 == "Romance" && tipo2 == "Drama") || (tipo1 == "Romance" && tipo2 == "Romance") || (tipo1 == "Scifi" && tipo2 == "Aventura") || (tipo1 == "Scifi" && tipo2 == "Scifi") || (tipo1 == "Muerto" && tipo2 == "Terror") || (tipo1 == "Terror" && tipo2 == "Accion") || (tipo1 == "Terror" && tipo2 == "Terror"))
            {
                return 1 / 2;
            }
            if ((tipo1 == "Historico" && tipo2 == "Suspenso") || (tipo1 == "Historico" && tipo2 == "Romance") || (tipo1 == "Historico" && tipo2 == "Scifi") || (tipo1 == "Suspenso" && tipo2 == "Comedia") || (tipo1 == "Suspenso" && tipo2 == "Romance") || (tipo1 == "Aventura" && tipo2 == "Historico") || (tipo1 == "Aventura" && tipo2 == "Suspenso") || (tipo1 == "Aventura" && tipo2 == "Drama") || (tipo1 == "Comedia" && tipo2 == "Aventura") || (tipo1 == "Comedia" && tipo2 == "Terror") || (tipo1 == "Accion" && tipo2 == "Suspenso") || (tipo1 == "Accion" && tipo2 == "Terror") || (tipo1 == "Drama" && tipo2 == "Historico") || (tipo1 == "Drama" && tipo2 == "Suspenso") || (tipo1 == "Drama" && tipo2 == "Romance") || (tipo1 == "Romance" && tipo2 == "Aventura") || (tipo1 == "Romance" && tipo2 == "Comedia") || (tipo1 == "Scifi" && tipo2 == "Drama") || (tipo1 == "Muerto" && tipo2 == "Muerto") || (tipo1 == "Terror" && tipo2 == "Muerto"))
            {
                return 2;
            }
            if ((tipo1 == "Accion" && tipo2 == "Muerto") || (tipo1 == "Scifi" && tipo2 == "Historico"))
            {
                return 0;
            }
            return 1;
        }

    }
}
