﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Batalla
    {
        Jugador jugadorActivo;
        bool finDePartida = false;
        Jugador jugadorGanador;
        

        Jugador elegirJugadorInicial(Jugador jugador1, Jugador jugador2) //elegir el jugador inicial con un random de 0 a 90, 50/50 de proba
        {
            Random rnd = new Random();
            int selector = rnd.Next(0, 91);

            if (selector <= 45)
            {
                this.jugadorActivo = jugador1;
            }
            else
            {
                this.jugadorActivo = jugador2;
            }

            return jugadorActivo;
        }

        public void turnoDePartida(string accion)
        {
            
        }

        public Jugador iniciarBatalla(Jugador jugador1, Jugador jugador2)
        {
            elegirJugadorInicial(jugador1, jugador2);

            while(finDePartida = false)
            {

            }

            return jugadorActivo;
        }
        

    }
}
