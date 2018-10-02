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

        private void CrearJugador1(string nombre)
        {
            jugador1 = new Jugador(nombre);
        }
        private void CrearJugador2(string nombre)
        {
            jugador2 = new Jugador(nombre);
        }
    }
}
