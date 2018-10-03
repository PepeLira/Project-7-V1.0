using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Brad_Pitt : Bitmon
    {
        public Brad_Pitt(string nombre, int hp, int estamina, int ataque, int defensa, int velocidad, string estado)
        {
            this.nombre = "Brad Pitt";
            this.hp = 50;
            this.Estamina = 100;
            this.ataque = 50;
            this.defensa = 50;
            this.velocidad = 50;
            this.estado = " ";
            ataques.Add(new Ataque("Whats in the Box", 60, 20, "Suspenso", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Aquiles Strenght", 0, 20, "Drama", 1, "Aumentar Ataque Activo", " ", " "));
            ataques.Add(new Ataque("Crazy Monkey", 0, 20, "Suspenso", 1, "Disminuir Hp Oponente", "Aumentar Velocidad Activo ", " "));
            ataques.Add(new Ataque("Reverse Growth", 0, 20, "Drama", 1, "Aumentar Hp Activo", " ", " "));
        }
    }
}
