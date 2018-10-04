using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class RobinWilliams : Bitmon
    {
        public RobinWilliams()
        {
            nombre = "Robin Williams";
            hp = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            estado = " ";
            tipo = "Muerto";
            ataques.Add(new Ataque("Oh Captain, my Captain", 40, 20, "Drama", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Fun", 40, 20, "Muerto", 1, "Disminuir Hp Oponente", "Aumentar Hp Activo", " "));
            ataques.Add(new Ataque("200 Years", 0, 20, "Muerto", 1, " ", " ", "Dormir"));
            ataques.Add(new Ataque("Prince Ali", 0, 20, "Comedia", 1, "Aumentar Ataque Activo", " ", ""));
        }
    }
}
