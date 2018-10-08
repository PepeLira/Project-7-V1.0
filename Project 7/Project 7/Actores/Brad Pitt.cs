using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    [Serializable]
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
            ataques.Add(new Ataque("Whats in the Box", 60, 20, "Suspenso", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Aquiles Strenght", 0, 20, "Drama", 1, "Aumentar Ataque Activo", " ", " "));
            ataques.Add(new Ataque("Crazy Monkey", 0, 20, "Suspenso", 1, "Disminuir Hp Oponente", "Aumentar Velocidad Activo ", " "));
            ataques.Add(new Ataque("Reverse Growth", 0, 20, "Drama", 1, "Aumentar Hp Activo", " ", " "));
        }
    }
}
