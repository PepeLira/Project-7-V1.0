using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    [Serializable]
    class Natalie_Portman : Bitmon
    {
        public Natalie_Portman()
        {
            nombre = "Natalie Portman";
            hp = 50;
            hpInicial = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            estado = " ";
            tipo = "Romance";
            ataques.Add(new Ataque("Arabesque", 50, 20, "Romance", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Please open the door", 0, 20, "Accion", 1, "Aumentar Hp Activo", " ", " "));
            ataques.Add(new Ataque("Aggresive Negociations", 40, 20, "Sci-fi", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Nice weiner", 30, 20, "Romance", 1, "Disminuir Hp Oponente", " ", "Confundir"));
        }
    }
}
