using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    [Serializable]
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
            ataques.Add(new Ataque("Dizziness", 0, 20, "Aventura", 1, "Aumentar Ataque Activo", " ", " "));
            ataques.Add(new Ataque("Ommpa-Loompas", 40, 20, "Aventura", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Tommy Gun", 30, 20, "Accion", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Cut", 40, 20, "Terror", 1, "Disminuir Hp Oponente", " ", " "));
        }
    }
}
