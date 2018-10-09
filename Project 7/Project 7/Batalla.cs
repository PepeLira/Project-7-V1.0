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
        Random rnd = new Random();

        void elegirJugadorInicial(Jugador jugador1, Jugador jugador2) //elegir el jugador inicial con un random de 0 a 90, 50/50 de proba
        {
            
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
            jugadorActivo.ataqueElegido = default(int);
            jugadorActivo.bitmonElegido = default(int);
            while (true)
            {
                jugadorActivo.ataqueElegido = default(int);
                jugadorActivo.bitmonElegido = default(int);
                int accion = consola.preguntarAccionTurno(jugadorActivo.nombre);
                jugadorActivo.jugada(accion); // Pregunta que accion tomara en su turno
                if (jugadorActivo.jugadaTurno == "atacar" && jugadorActivo.ataqueElegido != 9)
                {
                    break;
                }
                else if (jugadorActivo.jugadaTurno == "cambiar actor" && jugadorActivo.bitmonElegido != 9)
                {
                    break;
                }
                else if (accion == 1)
                {
                    break;
                }
            }
            

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
            if(jugadorAtacante.BitmonActivo.hp <= 0)
            {
                jugadorAtacante.BitmonDerrotado();
            }
            else if (jugadorAgredido.BitmonActivo.hp <= 0)
            {
                jugadorAgredido.BitmonDerrotado();
            }

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


        List<Jugador> JugadorMasRapido(Jugador jugador1, Jugador jugador2)
        {
            List<Jugador> actoresEnContienda = new List<Jugador>();
            if (jugador1.BitmonActivo.velocidad > jugador2.BitmonActivo.velocidad)
            {
                actoresEnContienda.Add(jugador1);
                actoresEnContienda.Add(jugador2);
                return actoresEnContienda;
            }
            else if (jugador1.BitmonActivo.velocidad < jugador2.BitmonActivo.velocidad)
            {
                actoresEnContienda.Add(jugador1);
                actoresEnContienda.Add(jugador2);
                return actoresEnContienda;
            }
            else
            {
                int selector = rnd.Next(0, 101);

                if (selector < 50)
                {
                    actoresEnContienda.Add(jugador1);
                    actoresEnContienda.Add(jugador2);
                    return actoresEnContienda;
                }
                else
                {
                    actoresEnContienda.Add(jugador1);
                    actoresEnContienda.Add(jugador2);
                    return actoresEnContienda;
                }
            }
        }


        public Jugador iniciarBatalla(Jugador jugador1, Jugador jugador2)
        {

            elegirJugadorInicial(jugador1, jugador2);

            while(true)
            {
                Jugador.GuardarJugador1(jugador1);
                Jugador.GuardarJugador2(jugador2);
                consola.MostrarBitmonsActivos(jugador1,jugador2);
                turno();
                turnoDelSiguienteJugador(jugador1, jugador2);
                consola.MostrarBitmonsActivos(jugador1, jugador2);
                turno();
                turnoDelSiguienteJugador(jugador1, jugador2);

                //Bitmons ejecutan acciones Pepe cosas: tiene que haber un metodo mejor para hacer esto, arreglado esto todo funcionaría perfecto

                List<Jugador> velocidadJugadores = JugadorMasRapido(jugador1, jugador2);

                bitmonEscuchanInstruccion(velocidadJugadores[0], velocidadJugadores[1]);
                if (revisarEstado(velocidadJugadores[0], velocidadJugadores[1]) != null)
                {
                    jugadorGanador = revisarEstado(velocidadJugadores[0], velocidadJugadores[1]);
                }
                bitmonEscuchanInstruccion(velocidadJugadores[1], velocidadJugadores[0]);
                if (revisarEstado(velocidadJugadores[1], velocidadJugadores[0]) != null)
                {
                    jugadorGanador = revisarEstado(velocidadJugadores[1], velocidadJugadores[0]);
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
