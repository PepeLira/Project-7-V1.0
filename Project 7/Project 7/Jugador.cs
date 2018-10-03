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
        private Bitmon[] bitmons;
        private Bitmon BitmonActivo;

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

        public void darUnaOrden(int ordenRecibida)
        {
            if(ordenRecibida == 0) //elegir ataque
            {
                Ataque ataqueElegido = consola.elegirAtaque(BitmonActivo.ataques); 
            }
            else if (ordenRecibida == 1) //descansar
            {
                
            }
            else if (ordenRecibida == 2) //cambiar actor
            {

            }
        }
    }
}
