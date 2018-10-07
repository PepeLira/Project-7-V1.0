﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Jugador
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
    }
}
