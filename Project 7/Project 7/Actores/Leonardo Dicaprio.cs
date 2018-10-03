using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Leonardo_Dicaprio : Bitmon
    {
        public Leonardo_Dicaprio()
        {
            nombre = "Leonardo Dicaprio";
            hp = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            estado = " ";
            tipo = "Drama";
            ataques[0]= (new Ataque("Frozen", 0, 20, "Drama", 1, "Aumentar Defensa Activo", " ", " "));
            ataques[1]= (new Ataque("Bear Claws", 50, 20, "Suspenso", 1, "Disminuir Hp Oponente", " ", " "));
            ataques[2]= (new Ataque("White Lines", 20, 20, "Drama", 1, "Disminuir Hp Oponente", "Aumentar Ataque Activo", " "));
            ataques[3]= (new Ataque("Spiner", 60, 20, "Comedia", 1, "DisminuirHpOponente", " ", "Confundir"));
        }
    }
}
