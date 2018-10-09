using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    [Serializable]
    class JackNicholson : Bitmon
    {
        public JackNicholson()
        {
            nombre = "Jack Nicholson";
            hp = 50;
            hpInicial = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            estado = " ";
            tipo = "Terror";
            ataques.Add(new Ataque("Here's Johnny", 70, 20, "Terror", 1, "DisminuirHpOponente", " ", " "));
            ataques.Add(new Ataque("Laugther", 20, 20, "Terror", 1, "DisminuirHpOponente", " ", "Paralizar"));
            ataques.Add(new Ataque("Fake Anger", 0, 20, "Comedia", 1, "AumentarAtaqueActivo", " ", " "));
            ataques.Add(new Ataque("Are you a cop?", 50, 20, "Suspenso", 1, "DisminuirHpOponente", " ", " "));
        }
    }
}
