using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Bitmon
    {
        public string nombre { get; set; }
        public int hp { get; set; }
        public int Estamina { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public int velocidad { get; set; }
        public string estado { get; set; }
        public List<Ataque> ataques { get; set; }

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
