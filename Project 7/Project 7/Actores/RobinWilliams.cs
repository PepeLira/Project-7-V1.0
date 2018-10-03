using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class RobinWilliams: Bitmon
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
            ataques[0]=(new Ataque("Oh Captain, my Captain",40,20,"Drama",1,"Disminuir Hp Oponente"," "," "));
            ataques[1]=(new Ataque("Fun", 40, 20, "Muerto", 1, "Disminuir Hp Oponente", "Aumentar Hp Activo", " "));
            ataques[2]=(new Ataque("200 Years", 0, 20, "Muerto", 1, " ", " ", "Dormir"));
            ataques[3]=(new Ataque("Prince Ali", 0, 20, "Comedia", 1, "Aumentar Ataque Activo", " ", ""));
        }
    }
}
