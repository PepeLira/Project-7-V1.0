using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Johnny_Deep : Bitmon
    {
        public Johnny_Deep(string nombre, int hp, int estamina, int ataque, int defensa, int velocidad, string estado)
        {
            this.nombre = "Johnny Deep";
            this.hp = 50;
            this.Estamina = 100;
            this.ataque = 50;
            this.defensa = 50;
            this.velocidad = 50;
            this.estado = " ";
            ataques.Add(new Ataque("Dizziness", 0, 20, "Aventura", 1, "Aumentar Presicion Activo", " ", " "));
            ataques.Add(new Ataque("Ommpa-Loompas", 40, 20, "Aventura", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Tommy Gun", 30, 20, "Accion", 1, "Disminuir Hp Oponente", " ", " "));
            ataques.Add(new Ataque("Cut", 40, 20, "Terror", 1, "Disminuir Hp Oponente", " ", " "));
        }
    }
}
