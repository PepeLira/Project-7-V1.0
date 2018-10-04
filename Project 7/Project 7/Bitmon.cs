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
        public string tipo { get; set; }
        public List<Ataque> ataques;
        public Juego juego = new Juego();

        // Pepecosas: necesitamos que Bitmon reciba una instrucción, la guarde y luego la ejecute cuando los dos jugadores hayan tomado sus desiciones.

        public void recibirAtaque(Ataque ataqueRecibido, Bitmon bitmonAgresor)// muchas opciones para hacerlo, podemos hacer que resiva el ataque elegido por el usuario 
        {
            hp = hp - (((ataqueRecibido.potencia+(bitmonAgresor.ataque/10))*juego.MultiplicadorTipo(bitmonAgresor.tipo, tipo))/(defensa/15));
        }
        public Ataque atacar(int ataqueElegido)
        {
            return ataques[ataqueElegido];
        }
        public void descansar()//La acción de descansar no infringe daño al bitmon enemigo, pero aumenta la estamina del 
        {                       //bitmon actual y además la defensa.
            Estamina += 10;
            defensa += 10;
        }

    }
}
