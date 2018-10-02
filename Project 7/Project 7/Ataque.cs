using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Ataque
    {
        string nombre;
        int potencia;
        int coste;
        string tipo;
        float accuracy;
        string efecto1; // Puede ser "cambiar de estado", "bajar hp", "bajar defensa", "bajar velocidad"... etc.
        string efecto2;// ataques podran tener dos efectos
        string estadoEfectuado; // por ejemplo si el bitmon se paraliza, necesitamos poder guardar est en un ataque. Si ataque no produce cambio de estado esto sera "null" supongo ':)

        public Ataque(string nombre, int potencia, int coste, string tipo, float accuracy, string efecto1, string efecto2, string estadoEfectuado)
        {
            this.nombre = nombre;
            this.potencia = potencia;
            this.coste = coste;
            this.tipo = tipo;
            this.accuracy = accuracy;
            this.efecto1 = efecto1;
            this.efecto2 = efecto2;
            this.estadoEfectuado = estadoEfectuado;
        }
    }
}
