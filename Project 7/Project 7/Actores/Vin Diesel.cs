using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Vin_Diesel : Bitmon
    {
        public Vin_Diesel()
        {
            nombre = "Vin Diesel";
            hp = 50;
            Estamina = 100;
            ataque = 50;
            defensa = 50;
            velocidad = 50;
            estado = " ";
            tipo = "Accion";
            ataques[0]=(new Ataque("Suuupeeermaaan", 100, 20, "Aventura", 1, "Disminuir Hp Oponente", "Disminuir Hp Activo", " "));
            ataques[1]= (new Ataque("I am Groot", 50, 20, "Aventura", 1, "Disminuir Hp Oponente", " ", "Paralizar"));
            ataques[2]= (new Ataque("N2O", 0, 20, "Accion", 1, "Aumentar Velocidad Activo", " ", " "));
            ataques[3]= (new Ataque("Peter Panda", 0, 20, "Terror", 1, "Aumentar Defensa Activo", " ", " "));
        }
    }
}
