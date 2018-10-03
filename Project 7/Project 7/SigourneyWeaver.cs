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
            hp = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            tipo = "Scifi";
            ataques.Add(new Ataque("Mecha Suit", 60, 20, "Scifi", 1, "DisminuirHpOponente", " ", " "));
            ataques.Add(new Ataque("Alien Queen", 100, 20, "Scifi", 1, "DisminuirHpActivo", " ", " "));
            ataques.Add(new Ataque("Cryogenic Sleep", 0, 20, "Scifi", 1, "AumentarHpActivo", " ", "DormirActivo"));
            ataques.Add(new Ataque("Na'vi Link", 40, 20, "Scifi", 1, "DisminuirHpOponente", " ", " "));
        }
    }
}
