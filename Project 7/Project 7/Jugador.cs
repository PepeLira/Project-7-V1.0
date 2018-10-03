using System;
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
        private Bitmon[] bitmons = new Bitmon[3];
        private Bitmon BitmonActivo;
        string jugadaTurno;
        int ataqueElegido;

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

        public void jugada(int ordenRecibida) // recibir la desicion tomada por el jugador por medio de la Consola
        {
            if(ordenRecibida == 0) //elegir ataque
            {
                jugadaTurno = "atacar";
                ataqueElegido = consola.elegirAtaque(BitmonActivo.ataques); 
            }
            else if (ordenRecibida == 1) //descansar
            {
                jugadaTurno = "descasar";
            }
            else if (ordenRecibida == 2) //cambiar actor
            {
                jugadaTurno = "cambiar actor";
                CambiarBitmon(1);
            }
        }
    }
}
