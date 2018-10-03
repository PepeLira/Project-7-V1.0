using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Jugador
    {
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

        public void darUnaOrden(string ordenRecibida)
        {
            if(ordenRecibida == "Atacar,")
            {
                Console.WriteLine("Seleccione Ataque");
                
            }
            else if (ordenRecibida == "Descansar")
            {

            }
            else if (ordenRecibida == "Cambiar")
            {

            }
        }
    }
}
