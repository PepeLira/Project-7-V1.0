using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Batalla
    {
        Consola consola = new Consola();
        Jugador jugadorActivo;
        bool finDePartida = false;
        Jugador jugadorGanador;
        

        void elegirJugadorInicial(Jugador jugador1, Jugador jugador2) //elegir el jugador inicial con un random de 0 a 90, 50/50 de proba
        {
            Random rnd = new Random();
            int selector = rnd.Next(0, 101);

            if (selector < 50)
            {
                this.jugadorActivo = jugador1;
            }
            else
            {
                this.jugadorActivo = jugador2;
            }
        }

        public void turno()
        {
            jugadorActivo.jugada(consola.preguntarAccionTurno(jugadorActivo.nombre)); // Pregunta que accion tomara en su turno

        }

        void turnoDelSiguienteJugador(Jugador jugador1, Jugador jugador2)
        {
            if (jugadorActivo == jugador1) 
            {
                this.jugadorActivo = jugador2;
            }
            else
            {
                this.jugadorActivo = jugador1;
            }
        }

        public Jugador iniciarBatalla(Jugador jugador1, Jugador jugador2)
        {
            elegirJugadorInicial(jugador1, jugador2);

            while(finDePartida == false)
            {
                turno();
                turnoDelSiguienteJugador(jugador1, jugador2);

            }

            return jugadorActivo;
        }
        

    }
}
