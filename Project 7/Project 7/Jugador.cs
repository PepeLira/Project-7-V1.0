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
            bitmons[posicion] = bitmon;
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
