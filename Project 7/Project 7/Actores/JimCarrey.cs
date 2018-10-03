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
            nombre = "Jim Carrey";
            hp = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            estado = " ";
            tipo = "Comedia";
            ataques[0]= (new Ataque("B-e-a-utiful", 40, 20, "Comedia", 1, "Disminuir Hp Oponente", " ", " "));
            ataques[1]= (new Ataque("Cuban Pete", 0, 20, "Comedia", 1, "Aumentar Hp Activo", " ", " "));
            ataques[2]= (new Ataque("Lies", 30, 20, "Comedia", 1, "Disminuir Hp Oponente", " ", "Paralizar"));
            ataques[3]= (new Ataque("Awful Idea", 60, 20, "Comedia", 1, "Disminuir Hp Oponente", " ", " "));
        }
    }
}
