using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Natalie_Portman : Bitmon
    {
        public Natalie_Portman(string nombre, int hp, int estamina, int ataque, int defensa, int velocidad, string estado)
        {
            this.nombre = "Natalie Portman";
            this.hp = 50;
            this.Estamina = 100;
            this.ataque = 50;
            this.defensa = 50;
            this.velocidad = 50;
            this.estado = " ";
            ataques.Add(new Ataque("Arabesque", 50, 20, "Romance", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Please open the door", 0, 20, "Accion", 1, "Aumentar Hp Activo", " ", " "));
            ataques.Add(new Ataque("Aggresive Negociations", 40, 20, "Sci-fi", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Nice weiner", 30, 20, "Romance", 1, "Disminuir Hp Oponente", " ", "Confundir"));
        }
    }
}
