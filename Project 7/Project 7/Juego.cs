using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

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
            CrearBitmons();
            CrearJugadores();
            DesplegarBitmons();
            AsignarBitmons();
            Console.Clear();
        }
        
        public void CrearBitmons()
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
                Console.WriteLine("Estamina:{0}", bitmon.Estamina);
                Console.WriteLine("Ataque:{0}", bitmon.ataque);
                Console.WriteLine("Defensa:{0}", bitmon.defensa);
                Console.WriteLine("======================================");
                count += 1;
            }
        }
        public void AsignarBitmons()
        {
            Console.WriteLine("Turno de {0} de elegir:",jugador1.nombre);
            jugador1.AgregarBitmon(0, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("{0} a elegido a {1}", jugador1.nombre, jugador1.bitmons[0].nombre);
            jugador1.BitmonActivo = jugador1.bitmons[0];
            Console.WriteLine("Turno de {0} de elegir:", jugador2.nombre);
            jugador2.AgregarBitmon(0, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("{0} a elegido a {1}", jugador2.nombre, jugador2.bitmons[0].nombre);
            jugador2.BitmonActivo = jugador2.bitmons[0];
            Console.WriteLine("Turno de {0} de elegir:", jugador2.nombre);
            jugador2.AgregarBitmon(1, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("{0} a elegido a {1}", jugador2.nombre, jugador2.bitmons[1].nombre);
            Console.WriteLine("Turno de {0} de elegir:", jugador1.nombre);
            jugador1.AgregarBitmon(1, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("{0} a elegido a {1}", jugador1.nombre, jugador1.bitmons[1].nombre);
            Console.WriteLine("Turno de {0} de elegir:", jugador1.nombre);
            jugador1.AgregarBitmon(2, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("{0} a elegido a {1}", jugador1.nombre, jugador1.bitmons[2].nombre);
            Console.WriteLine("Turno de {0} de elegir:", jugador2.nombre);
            jugador2.AgregarBitmon(2, bitmons[Consola.ElegirBitmon(bitmons) - 1]);
            Console.WriteLine("{0} a elegido a {1}",jugador2.nombre ,jugador2.bitmons[2].nombre);
        }
        public void Batalla()
        {
            Batalla batalla = new Batalla();
            batalla.iniciarBatalla(jugador1, jugador2);
        }

        public void GuardarJuego(Juego juego)
        {
            Stream stream = File.Open("JuegoGuardado.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, juego);
            stream.Close();
        }

        public Juego RecuperarJuego()
        {
            Juego juego;
            Stream stream = File.Open("JuegoGuardado.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            juego = (Juego)bf.Deserialize(stream);
            stream.Close();
            return juego;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Jugador1", jugador1);
            info.AddValue("Jugador2", jugador2);
        }

        public Juego(SerializationInfo info, StreamingContext context)
        {
            jugador1 = (Jugador)info.GetValue("Jugador1", typeof(Jugador));
            jugador2 = (Jugador)info.GetValue("Jugador2",typeof(Jugador));
        }
    }
}
