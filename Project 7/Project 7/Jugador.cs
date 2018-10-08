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
    class Jugador : ISerializable
    {
        Consola consola = new Consola();
        public string nombre { get; }
        public Bitmon[] bitmons = new Bitmon[3];
        public Bitmon BitmonActivo { get; set; }
        public string jugadaTurno { get; set; }
        public int ataqueElegido;
        public string estadoJugador = "en combate";

        public Jugador(string nombre)
        {
            this.nombre = nombre;
        }

        private void CambiarBitmon(int posicion)
        {
            BitmonActivo = bitmons[posicion];
        
        }

        public void AgregarBitmon(int posicion, Bitmon bitmon)
        {
            if (bitmon.nombre == "Brad Pitt")
            {
                bitmons[posicion] = new Brad_Pitt();
            }
            if (bitmon.nombre == "Jim Carrey")
            {
                bitmons[posicion] = new JimCarrey();
            }
            if (bitmon.nombre == "Johnny Deep")
            {
                bitmons[posicion] = new Johnny_Deep();
            }
            if (bitmon.nombre == "Leonardo Dicaprio")
            {
                bitmons[posicion] = new Leonardo_Dicaprio();
            }
            if (bitmon.nombre == "Natalie Portman")
            {
                bitmons[posicion] = new Natalie_Portman();
            }
            if (bitmon.nombre == "Robin Williams")
            {
                bitmons[posicion] = new RobinWilliams();
            }
            if (bitmon.nombre == "Sigourney Weaver")
            {
                bitmons[posicion] = new SigourneyWeaver();
            }
            if (bitmon.nombre == "Tom Hanks")
            {
                bitmons[posicion] = new TomHanks();
            }
            if (bitmon.nombre == "Vin Diesel")
            {
                bitmons[posicion] = new Vin_Diesel();
            }
            if (bitmon.nombre == "Jack Nicholson")
            {
                bitmons[posicion] = new JackNicholson();
            }
        }



        public void BitmonDerrotado()
        {
            while (true)
            {
                int bitmonElegido = consola.elegirBitmon(bitmons, nombre);

                int cont = 0;

                for (int i = 0; i < 3; i += 1)
                {
                    if (bitmons[i].hp == 0)
                    {
                        cont += 1;
                    }
                }
                if (cont == 3)
                {
                    estadoJugador = "Derrotado";
                    break;
                }

                else if (bitmons[bitmonElegido] == BitmonActivo || bitmons[bitmonElegido].hp == 0)
                {
                    Console.WriteLine("Actor activo o derrotado, elige otro!");
                }
                else
                {
                    
                    CambiarBitmon(bitmonElegido);
                    break;
                }

            }
        }


        public void jugada(int ordenRecibida) // recibir la desicion tomada por el jugador por medio de la Consola
        {
            if(ordenRecibida == 0) //elegir ataque
            {
                jugadaTurno = "atacar";
                ataqueElegido = consola.elegirAtaque(BitmonActivo.ataques,nombre); 
            }
            else if (ordenRecibida == 1) //descansar
            {
                jugadaTurno = "descasar";
            }
            else if (ordenRecibida == 2) //cambiar actor pepeCosas: necesito solucionar el caso de que pasa si solo queda un bitmon con Hp != de 0
            {
                jugadaTurno = "cambiar actor";
                
                while (true)
                {
                    int bitmonElegido = consola.elegirBitmon(bitmons,nombre);
                    if (bitmons[bitmonElegido] == BitmonActivo)
                    {
                        Console.WriteLine("Actor activo, elige otro!");
                    }
                    else
                    {
                        CambiarBitmon(bitmonElegido);
                        break;
                    }
                }
                
            }
        }

        public static void GuardarJugador1(Jugador jugador)
        {
            try
            {
                Stream stream = File.Open("Jugador1.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, jugador);
                stream.Close();
            }catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine("No hay un juego guardado en la ruta elegida.");
            }
        }
        public static void GuardarJugador2(Jugador jugador)
        {
            try
            {
                Stream stream = File.Open("Jugador2.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, jugador);
                stream.Close();
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine("");
            }
        }
        public static Jugador RecuperarJugador1()
        {
            Jugador jugador;
            Stream stream = File.Open("Jugador1.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            jugador = (Jugador)bf.Deserialize(stream);
            stream.Close();
            return jugador;
        }
        public static Jugador RecuperarJugador2()
        {
            Jugador jugador;
            Stream stream = File.Open("Jugador2.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            jugador = (Jugador)bf.Deserialize(stream);
            stream.Close();
            return jugador;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Nombre", nombre);
            info.AddValue("Bitmons", bitmons);
            info.AddValue("BitmonActivo", BitmonActivo);
            info.AddValue("JugadaTurno", jugadaTurno);
            info.AddValue("AtaqueElegido", ataqueElegido);
            info.AddValue("EstadoJugador", estadoJugador);
        }
        public Jugador(SerializationInfo info, StreamingContext context)
        {
            nombre = (string)info.GetValue("Nombre", typeof(string));
            bitmons = (Bitmon[])info.GetValue("Bitmons", typeof(Bitmon[]));
            BitmonActivo = (Bitmon)info.GetValue("BitmonActivo", typeof(Bitmon));
            jugadaTurno = (string)info.GetValue("JugadaTurno", typeof(string));
            ataqueElegido = (int)info.GetValue("AtaqueElegido", typeof(int));
            estadoJugador = (string)info.GetValue("EstadoJugador", typeof(string));
        }
    }
}
