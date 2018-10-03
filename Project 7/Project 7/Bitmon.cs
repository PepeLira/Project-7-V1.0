using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Bitmon
    {
        public string nombre { get; }
        public int hp { get; }
        public int Estamina { get; }
        public int ataque { get; }
        public int defensa { get; }
        public int velocidad { get; }
        public string estado { get; }
        public List<Ataque> ataques { get; }

        public void recibirAtaque()// muchas opciones para hacerlo, podemos hacer que resiva el ataque elegido por el usuario 
        {
            
        }
        public int atacar(Ataque ataqueElegido)
        {
            return 0 ;
        }
        public void recuperarEstamina()
        {

        }

    }
}
