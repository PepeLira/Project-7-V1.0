using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project_7
{
    [Serializable()]
    class Juego: ISerializable
    {
        private Jugador jugador1;
        private Jugador jugador2;
        private List<Bitmon> bitmons = new List<Bitmon>();

        public Juego()
        {
            bitmons.Add(new RobinWilliams());
            bitmons.Add(new Brad_Pitt());
            bitmons.Add(new SigourneyWeaver());
            bitmons.Add(new JimCarrey());
            bitmons.Add(new TomHanks());
            bitmons.Add(new Johnny_Deep());
            bitmons.Add(new Natalie_Portman());
            bitmons.Add(new Vin_Diesel());
            bitmons.Add(new Leonardo_Dicaprio());
            bitmons.Add(new JackNicholson());
        }
        public void CrearJugadores()
        {
            Console.WriteLine("Jugador 1");
            string nombre1 = Consola.PedirNombre();
            jugador1 = new Jugador(nombre1);
            Console.WriteLine("Jugador 2");
            string nombre2 = Consola.PedirNombre();
            jugador2 = new Jugador(nombre2);
        }
        public void DesplegarBitmons()
        {
            int count = 1;
            foreach (Bitmon bitmon in bitmons)
            {
                Console.WriteLine("({0})", count);
                Console.WriteLine(bitmon.nombre);
                Console.WriteLine("Tipo:{0}", bitmon.tipo);
                Console.WriteLine("HP:{0}", bitmon.hp);
                Console.WriteLine("Estamina{0}", bitmon.Estamina);
                Console.WriteLine("Ataque{0}", bitmon.ataque);
                Console.WriteLine("Defensa{0}", bitmon.defensa);
                Console.WriteLine("======================================");
                count += 1;
            }
        }
        public void AsignarBitmons()
        {
            Console.WriteLine("Jugador 1");
            jugador1.AgregarBitmon(0, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("Jugador 1 a elegido a {0}",jugador1.bitmons[0].nombre);
            Console.WriteLine("Jugador 2");
            jugador2.AgregarBitmon(0, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("Jugador 2 a elegido a {0}", jugador1.bitmons[0].nombre);
            Console.WriteLine("Jugador 2");
            jugador2.AgregarBitmon(1, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("Jugador 2 a elegido a {0}", jugador1.bitmons[1].nombre);
            Console.WriteLine("Jugador 1");
            jugador1.AgregarBitmon(1, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("Jugador 1 a elegido a {0}", jugador1.bitmons[1].nombre);
            Console.WriteLine("Jugador 1");
            jugador1.AgregarBitmon(2, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("Jugador 1 a elegido a {0}", jugador1.bitmons[2].nombre);
            Console.WriteLine("Jugador 2");
            jugador2.AgregarBitmon(2, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("Jugador 2 a elegido a {0}", jugador1.bitmons[2].nombre);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Jugador1", jugador1);
            info.AddValue("Jugador2", jugador2);
            info.AddValue("Bitmons", bitmons);
        }

        public Juego(SerializationInfo info, StreamingContext context)
        {
            //jugador1 = (Jugador)info.GetValue("Jugador1");
            //jugador2 = (Jugador)info.GetValue("Jugador2");
        }
    }
}
