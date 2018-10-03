using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class JimCarrey:Bitmon
    {
        public JimCarrey()
        {
            hp = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            tipo = "Comedia";
            ataques.Add(new Ataque("B-e-a-utiful", 40, 20, "Comedia", 1, "DisminuirHpOponente", " ", " "));
            ataques.Add(new Ataque("Cuban Pete", 0, 20, "Comedia", 1, "AumentarHpActivo", " ", " "));
            ataques.Add(new Ataque("Lies", 30, 20, "Comedia", 1, "DisminuirHpOponente", " ", "Paralizar"));
            ataques.Add(new Ataque("Awful Idea", 60, 20, "Comedia", 1, "DisminuirHpOponente", " ", " "));
        }
    }
}
