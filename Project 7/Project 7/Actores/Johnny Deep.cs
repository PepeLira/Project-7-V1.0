using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Johnny_Deep : Bitmon
    {
        public Johnny_Deep()
        {
            nombre = "Johnny Deep";
            hp = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            estado = " ";
            tipo = "Aventura";
            ataques[0]= (new Ataque("Dizziness", 0, 20, "Aventura", 1, "Aumentar Ataque Activo", " ", " "));
            ataques[1]= (new Ataque("Ommpa-Loompas", 40, 20, "Aventura", 1, "Disminuir Hp Oponente", " ", " "));
            ataques[2]= (new Ataque("Tommy Gun", 30, 20, "Accion", 1, "Disminuir Hp Oponente", " ", " "));
            ataques[3]= (new Ataque("Cut", 40, 20, "Terror", 1, "Disminuir Hp Oponente", " ", " "));
        }
    }
}
