using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    [Serializable]
    class SigourneyWeaver:Bitmon
    {
        public SigourneyWeaver()
        {
            nombre = "Sigourney Weaver";
            hp = 50;
            hpInicial = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            estado = " ";
            tipo = "Scifi";
            ataques.Add(new Ataque("Mecha Suit", 60, 20, "Scifi", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Alien Queen", 100, 20, "Scifi", 1, "Disminuir Hp Activo", " ", " "));
            ataques.Add(new Ataque("Cryogenic Sleep", 0, 20, "Scifi", 1, "Aumentar Hp Activo", " ", "Dormir Activo"));
            ataques.Add(new Ataque("Na'vi Link", 40, 20, "Scifi", 1, "Disminuir Hp Oponente", " ", " "));
        }
    }
}
