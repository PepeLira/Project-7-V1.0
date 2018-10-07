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
        public List<Ataque> ataques = new List<Ataque>();

        // Pepecosas: necesitamos que Bitmon reciba una instrucción, la guarde y luego la ejecute cuando los dos jugadores hayan tomado sus desiciones.

        public void recibirAtaque(Ataque ataqueRecibido, Bitmon bitmonAgresor)// muchas opciones para hacerlo, podemos hacer que resiva el ataque elegido por el usuario 
        {
            if (ataqueRecibido.efecto1 == "Disminuir Defensa Oponente" || ataqueRecibido.efecto2 == "Disminuir Defensa Oponente")
            {
                defensa = defensa - 15;
            }
            if (ataqueRecibido.efecto1 == "Disminuir Velocidad Oponente" || ataqueRecibido.efecto2 == "Disminuir Velocidad Oponente")
            {
                velocidad = velocidad - 15;
            }
            if (ataqueRecibido.efecto1 == "Disminuir Ataque Oponente" || ataqueRecibido.efecto2 == "Disminuir Ataque Oponente")
            {
                ataque = ataque - 15;
            }
            if (ataqueRecibido.efecto1 == "Dormir")
            {
                estado = "Dormido";
            }
            if (ataqueRecibido.efecto1 == "Paralizar")
            {
                estado = "Paralizado";
            }
            if (ataqueRecibido.estadoEfectuado == "Confundir")
            {
                estado = "Confundido";
            }
            if ((ataqueRecibido.potencia > 0) && (ataqueRecibido.efecto1 == "Disminuir Hp Oponente" || ataqueRecibido.efecto2 == "Disminuir Hp Oponente"))
            {
                hp = hp - (((ataqueRecibido.potencia + (bitmonAgresor.ataque / 10)) * Batalla.MultiplicadorTipo(ataqueRecibido.tipo, tipo)) / (defensa / 15));
                if (hp <= 0)
                {
                    hp = 0;
                    estado = "Derrotado";
                }
            }


        }

        public Ataque atacar(int ataqueElegido)//Atacar ademas de retornar el ataque que afecta al bitmon contrario, aplica los efectos al bitmon atacante si es que los hay.
        {
            if ((ataques[ataqueElegido].potencia > 0) && ((ataques[ataqueElegido].efecto1 == "Disminuir Hp Activo" || ataques[ataqueElegido].efecto2 == "Disminuir Hp Activo")) && (ataques[ataqueElegido].nombre == "Suuupeeermaaan" || ataques[ataqueElegido].nombre == "Alien Queen"))
            {
                hp = 0;
            }
            if (ataques[ataqueElegido].efecto1 == "Disminuir Defensa Activo" || ataques[ataqueElegido].efecto2 == "Disminuir Defensa Activo")
            {
                defensa = defensa - 15;
            }
            if (ataques[ataqueElegido].efecto1 == "Disminuir Velocidad Activo" || ataques[ataqueElegido].efecto2 == "Disminuir Velocidad Activo")
            {
                velocidad = velocidad - 15;
            }
            if (ataques[ataqueElegido].efecto1 == "Disminuir Ataque Activo" || ataques[ataqueElegido].efecto2 == "Disminuir Ataque Activo")
            {
                ataque = ataque - 15;
            }
            if (ataques[ataqueElegido].efecto1 == "Aumentar Defensa Activo" || ataques[ataqueElegido].efecto2 == "Aumentar Defensa Activo")
            {
                defensa = defensa + 15;
            }
            if (ataques[ataqueElegido].efecto1 == "Aumentar Velocidad Activo" || ataques[ataqueElegido].efecto2 == "Aumentar Velocidad Activo")
            {
                velocidad = velocidad + 15;
            }
            if (ataques[ataqueElegido].efecto1 == "Aumentar Ataque Activo" || ataques[ataqueElegido].efecto2 == "Aumentar Ataque Activo")
            {
                ataque = ataque + 15;
            }
            if (ataques[ataqueElegido].efecto1 == "Dormir Activo")
            {
                estado = "Dormido";
            }
            if (ataques[ataqueElegido].efecto1 == "Paralizar Activo")
            {
                estado = "Paralizado";
            }
            if (ataques[ataqueElegido].estadoEfectuado == "Confundir Activo")
            {
                estado = "Confundido";
            }
            return ataques[ataqueElegido];
        }
        public void descansar()//La acción de descansar no infringe daño al bitmon enemigo, pero aumenta la estamina del 
        {                       //bitmon actual y además la defensa.
            Estamina += 10;
            defensa += 10;
        }

    }
}
