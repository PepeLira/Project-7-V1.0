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
        private List<Bitmon> bitmons;
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
            if(ordenRecibida == "atacar")
            {
                Console.WriteLine("Seleccione Ataque");
                
            }
        }
    }
}
