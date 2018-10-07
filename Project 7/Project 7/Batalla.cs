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

        void turno()
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

        void bitmonEscuchanInstruccion(Jugador jugadorAtacante, Jugador jugadorAgredido) //pepe cosas: Bitmon tiene que poder activar metodo de recivir daño en su oponente 
        {
            if (jugadorAtacante.jugadaTurno == "atacar")
            {
                jugadorAgredido.BitmonActivo.recibirAtaque(jugadorAtacante.BitmonActivo.atacar(jugadorAtacante.ataqueElegido), jugadorAtacante.BitmonActivo);
            }
            else if (jugadorAtacante.jugadaTurno == "descasar")
            {
                jugadorAtacante.BitmonActivo.descansar();
            }
            else if (jugadorAtacante.jugadaTurno == "cambiar actor")
            {
                //nothing happens.
            }
        }

        Jugador revisarEstado(Jugador jugadorAtacante, Jugador jugadorAgredido)
        {
            jugadorAgredido.BitmonDerrotado();
            jugadorAtacante.BitmonDerrotado();

            if (jugadorAgredido.estadoJugador == "Derrotado")
            {
                return jugadorAtacante;
            }
            else if (jugadorAtacante.estadoJugador == "Derrotado")
            {
                return jugadorAgredido;
            }
            else
            {
                return null;
            }
        }

        public Jugador iniciarBatalla(Jugador jugador1, Jugador jugador2)
        {
            elegirJugadorInicial(jugador1, jugador2);

            while(true)
            {
                turno();
                turnoDelSiguienteJugador(jugador1, jugador2);
                turno();
                turnoDelSiguienteJugador(jugador1, jugador2);

                //Bitmons ejecutan acciones

                int i = 0;
                while ( i < 2)
                {
                    if (jugador1.BitmonActivo.velocidad > jugador2.BitmonActivo.velocidad && i == 0)
                    {
                        bitmonEscuchanInstruccion(jugador1,jugador2);
                        if (revisarEstado(jugador1, jugador2) != null)
                        {
                            jugadorGanador = revisarEstado(jugador1, jugador2);
                            break;
                        }
                    }
                    else if (jugador2.BitmonActivo.velocidad > jugador1.BitmonActivo.velocidad && i == 0)
                    {
                        bitmonEscuchanInstruccion(jugador2,jugador1);
                        if (revisarEstado(jugador1, jugador2) != null)
                        {
                            jugadorGanador = revisarEstado(jugador1, jugador2);
                            break;
                        }
                    }
                    if (jugador1.BitmonActivo.velocidad > jugador2.BitmonActivo.velocidad && i == 1)
                    {
                        bitmonEscuchanInstruccion(jugador2,jugador1);
                        if (revisarEstado(jugador1, jugador2) != null)
                        {
                            jugadorGanador = revisarEstado(jugador1, jugador2);
                            break;
                        }
                    }
                    else if (jugador2.BitmonActivo.velocidad > jugador1.BitmonActivo.velocidad && i == 1)
                    {
                        bitmonEscuchanInstruccion(jugador1,jugador2);
                        if (revisarEstado(jugador1, jugador2) != null)
                        {
                            jugadorGanador = revisarEstado(jugador1, jugador2);
                            break;
                        }
                    }

                    i += 1;
                }
                if (jugadorGanador != null)
                {
                    break;
                }
            }
            return jugadorGanador;
        }

        public static int MultiplicadorTipo(string tipo1, string tipo2)
        {
            if ((tipo1 == "Historico" && tipo2 == "Aventura") || (tipo1 == "Historico" && tipo2 == "Comedia") || (tipo1 == "Suspenso" && tipo2 == "Historico") || (tipo1 == "Suspenso" && tipo2 == "Accion") || (tipo1 == "Aventura" && tipo2 == "Aventura") || (tipo1 == "Aventura" && tipo2 == "Comedia") || (tipo1 == "Aventura" && tipo2 == "Romance") || (tipo1 == "Comedia" && tipo2 == "Accion") || (tipo1 == "Comedia" && tipo2 == "Romance") || (tipo1 == "Comedia" && tipo2 == "Muerto") || (tipo1 == "Accion" && tipo2 == "Comedia") || (tipo1 == "Drama" && tipo2 == "Aventura") || (tipo1 == "Drama" && tipo2 == "Drama") || (tipo1 == "Romance" && tipo2 == "Suspenso") || (tipo1 == "Romance" && tipo2 == "Drama") || (tipo1 == "Romance" && tipo2 == "Romance") || (tipo1 == "Scifi" && tipo2 == "Aventura") || (tipo1 == "Scifi" && tipo2 == "Scifi") || (tipo1 == "Muerto" && tipo2 == "Terror") || (tipo1 == "Terror" && tipo2 == "Accion") || (tipo1 == "Terror" && tipo2 == "Terror"))
            {
                return 1 / 2;
            }
            else if ((tipo1 == "Historico" && tipo2 == "Suspenso") || (tipo1 == "Historico" && tipo2 == "Romance") || (tipo1 == "Historico" && tipo2 == "Scifi") || (tipo1 == "Suspenso" && tipo2 == "Comedia") || (tipo1 == "Suspenso" && tipo2 == "Romance") || (tipo1 == "Aventura" && tipo2 == "Historico") || (tipo1 == "Aventura" && tipo2 == "Suspenso") || (tipo1 == "Aventura" && tipo2 == "Drama") || (tipo1 == "Comedia" && tipo2 == "Aventura") || (tipo1 == "Comedia" && tipo2 == "Terror") || (tipo1 == "Accion" && tipo2 == "Suspenso") || (tipo1 == "Accion" && tipo2 == "Terror") || (tipo1 == "Drama" && tipo2 == "Historico") || (tipo1 == "Drama" && tipo2 == "Suspenso") || (tipo1 == "Drama" && tipo2 == "Romance") || (tipo1 == "Romance" && tipo2 == "Aventura") || (tipo1 == "Romance" && tipo2 == "Comedia") || (tipo1 == "Scifi" && tipo2 == "Drama") || (tipo1 == "Muerto" && tipo2 == "Muerto") || (tipo1 == "Terror" && tipo2 == "Muerto"))
            {
                return 2;
            }
            else if ((tipo1 == "Accion" && tipo2 == "Muerto") || (tipo1 == "Scifi" && tipo2 == "Historico"))
            {
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

    }
}
