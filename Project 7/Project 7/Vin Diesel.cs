using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Vin_Diesel : Bitmon
    {
        public Vin_Diesel(string nombre, int hp, int estamina, int ataque, int defensa, int velocidad, string estado)
        {
            this.nombre = "Vin Diesel";
            this.hp = 50;
            this.Estamina = 100;
            this.ataque = 50;
            this.defensa = 50;
            this.velocidad = 50;
            this.estado = " ";
            ataques.Add(new Ataque("Suuupeeermaaan", 100, 20, "Aventura", 1, "Disminuir Hp Oponente", "Disminuir Hp Activo", " "));
            ataques.Add(new Ataque("I am Groot", 50, 20, "Aventura", 1, "Disminuir Hp Oponente", " ", "Paralizar "));
            ataques.Add(new Ataque("N2O", 0, 20, "Accion", 1, "Aumentar Velocidad Activo", " ", " "));
            ataques.Add(new Ataque("Peter Panda", 0, 20, "Terror", 1, "Aumentar Presicion Activo", " ", " "));
        }
    }
}
