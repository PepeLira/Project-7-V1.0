using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class SigourneyWeaver:Bitmon
    {
        public SigourneyWeaver()
        {
            nombre = "Sigourney Weaver";
            hp = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            estado = " ";
            tipo = "Scifi";
            ataques[0]=(new Ataque("Mecha Suit", 60, 20, "Scifi", 1, "Disminuir Hp Oponente", " ", " "));
            ataques[1]=(new Ataque("Alien Queen", 100, 20, "Scifi", 1, "Disminuir Hp Activo", " ", " "));
            ataques[2]=(new Ataque("Cryogenic Sleep", 0, 20, "Scifi", 1, "Aumentar Hp Activo", " ", "Dormir Activo"));
            ataques[3]=(new Ataque("Na'vi Link", 40, 20, "Scifi", 1, "Disminuir Hp Oponente", " ", " "));
        }
    }
}
