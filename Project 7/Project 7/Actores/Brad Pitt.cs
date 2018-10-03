using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Brad_Pitt : Bitmon
    {
        public Brad_Pitt()
        {
            nombre = "Brad Pitt";
            hp = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            estado = " ";
            tipo = "Suspenso";
            ataques[0]= (new Ataque("Whats in the Box", 60, 20, "Suspenso", 1, "Disminuir Hp Oponente", " ", " "));
            ataques[1]= (new Ataque("Aquiles Strenght", 0, 20, "Drama", 1, "Aumentar Ataque Activo", " ", " "));
            ataques[2]= (new Ataque("Crazy Monkey", 0, 20, "Suspenso", 1, "Disminuir Hp Oponente", "Aumentar Velocidad Activo ", " "));
            ataques[3]= (new Ataque("Reverse Growth", 0, 20, "Drama", 1, "Aumentar Hp Activo", " ", " "));
        }
    }
}
