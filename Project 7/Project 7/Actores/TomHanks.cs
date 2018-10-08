using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    [Serializable]
    class TomHanks :Bitmon
    {
        public TomHanks()
        {
            nombre = "Tom Hanks";
            hp = 50;
            hpInicial = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            estado = " ";
            tipo = "Historico";
            ataques.Add(new Ataque("Run, Forest, Run", 0, 20, "Historico", 1, "Aumentar Velocidad Activo", " ", " "));
            ataques.Add(new Ataque("Wilson", 60, 20, "Drama", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Jomare", 0, 20, "Historico", 1, "Aumentar Defensa Activo", " ", " "));
            ataques.Add(new Ataque("You are a Toy", 60, 20, "Comedia", 1, "Disminuir Hp Oponente", " ", " "));
        }
    }
}
