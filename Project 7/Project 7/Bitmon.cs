using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    [Serializable]
    class Bitmon
    {
        public string nombre { get; set; }
        public int hp { get; set; }
        public int hpInicial { get; set; }
        public int Estamina { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public int velocidad { get; set; }
        public string estado { get; set; }
        public string tipo { get; set; }
        public List<Ataque> ataques = new List<Ataque>();

        // Pepecosas: necesitamos que Bitmon reciba una instrucción, la guarde y luego la ejecute cuando los dos jugadores hayan tomado sus desiciones.

        public void recibirAtaque(Ataque ataqueRecibido, Bitmon bitmonAgresor)// muchas opciones para hacerlo, podemos hacer que resiva el ataque elegido por el usuario 
        {
            if (ataqueRecibido.efecto1 == "Disminuir Defensa Oponente" || ataqueRecibido.efecto2 == "Disminuir Defensa Oponente")
            {
                Console.WriteLine("La defensa de {0} ha bajado.", nombre);
                Console.ReadLine();
                defensa = defensa - 15;
            }
            if (ataqueRecibido.efecto1 == "Disminuir Velocidad Oponente" || ataqueRecibido.efecto2 == "Disminuir Velocidad Oponente")
            {
                Console.WriteLine("La velocidad de {0} ha bajado.", nombre);
                Console.ReadLine();
                velocidad = velocidad - 15;
            }
            if (ataqueRecibido.efecto1 == "Disminuir Ataque Oponente" || ataqueRecibido.efecto2 == "Disminuir Ataque Oponente")
            {
                Console.WriteLine("El ataque de {0} ha bajado.", nombre);
                Console.ReadLine();
                ataque = ataque - 15;
            }
            if (ataqueRecibido.estadoEfectuado == "Dormir")
            {
                Console.WriteLine("{0} se ha dormido, quizas no despierte.", nombre);
                Console.ReadLine();
                estado = "Dormido";
            }
            if (ataqueRecibido.estadoEfectuado == "Paralizar")
            {
                Console.WriteLine("{0} ha sido paralizado, quizas no ataque.", nombre);
                Console.ReadLine();
                estado = "Paralizado";
            }
            if (ataqueRecibido.estadoEfectuado == "Confundir")
            {
                Console.WriteLine("{0} esta confundido.", nombre);
                Console.ReadLine();
                estado = "Confundido";
            }
            if ((ataqueRecibido.potencia > 0) && (ataqueRecibido.efecto1 == "Disminuir Hp Oponente" || ataqueRecibido.efecto2 == "Disminuir Hp Oponente"))
            {
                Console.WriteLine("{0} recibe {1} de daño.",nombre,(((ataqueRecibido.potencia + (bitmonAgresor.ataque / 10)) * Batalla.MultiplicadorTipo(ataqueRecibido.tipo, tipo)) / (defensa / 15)));
                Console.ReadLine();
                hp = hp - (((ataqueRecibido.potencia + (bitmonAgresor.ataque / 10)) * Batalla.MultiplicadorTipo(ataqueRecibido.tipo, tipo)) / (defensa / 15));
                if (hp <= 0)
                {
                    Console.WriteLine("{0} ha sido derrotado.", nombre);
                    Console.ReadLine();
                    hp = 0;
                    estado = "Derrotado";
                }
            }


        }

        public Ataque atacar(int ataqueElegido)//Atacar ademas de retornar el ataque que afecta al bitmon contrario, aplica los efectos al bitmon atacante si es que los hay.
        {
            if (ataques[ataqueElegido].coste > Estamina)
            {
                Console.WriteLine("{0} no ha podido usar {1} por falta de estamina. {0} necesita descansar.", nombre, ataques[ataqueElegido].nombre);
                return null;
            }
            else
            {
                Console.WriteLine("{0} ha usado {1}.", nombre, ataques[ataqueElegido].nombre);
                Console.ReadLine();
                if ((ataques[ataqueElegido].potencia > 0) && ((ataques[ataqueElegido].efecto1 == "Disminuir Hp Activo" || ataques[ataqueElegido].efecto2 == "Disminuir Hp Activo")) && (ataques[ataqueElegido].nombre == "Suuupeeermaaan" || ataques[ataqueElegido].nombre == "Alien Queen"))
                {
                    hp = hp ;
                }
                if (ataques[ataqueElegido].efecto1 == "Disminuir Defensa Activo" || ataques[ataqueElegido].efecto2 == "Disminuir Defensa Activo")
                {
                    Console.WriteLine("La defensa de {0} ha bajado.", nombre);
                    Console.ReadLine();
                    defensa = defensa - 15;
                }
                if (ataques[ataqueElegido].efecto1 == "Disminuir Velocidad Activo" || ataques[ataqueElegido].efecto2 == "Disminuir Velocidad Activo")
                {
                    Console.WriteLine("La velocidad de {0} ha bajado.", nombre);
                    Console.ReadLine();
                    velocidad = velocidad - 15;
                }
                if (ataques[ataqueElegido].efecto1 == "Disminuir Ataque Activo" || ataques[ataqueElegido].efecto2 == "Disminuir Ataque Activo")
                {
                    ataque = ataque - 15;
                    Console.WriteLine("El ataque de {0} ha bajado.", nombre);
                    Console.ReadLine();
                }
                if (ataques[ataqueElegido].efecto1 == "Aumentar Hp Activo" || ataques[ataqueElegido].efecto2 == "Aumentar Hp Activo")
                {
                    Console.WriteLine("{0} se ha curado.", nombre);
                    Console.ReadLine();
                    hp = hp + 20;
                    if (hp >= hpInicial)
                    {
                        hp = hpInicial;
                    }
                }
                if (ataques[ataqueElegido].efecto1 == "Aumentar Defensa Activo" || ataques[ataqueElegido].efecto2 == "Aumentar Defensa Activo")
                {
                    Console.WriteLine("La defensa de {0} ha aumentado.", nombre);
                    Console.ReadLine();
                    defensa = defensa + 15;
                }
                if (ataques[ataqueElegido].efecto1 == "Aumentar Velocidad Activo" || ataques[ataqueElegido].efecto2 == "Aumentar Velocidad Activo")
                {
                    Console.WriteLine("La velocidad de {0} ha aumentado.", nombre);
                    Console.ReadLine();
                    velocidad = velocidad + 15;
                }
                if (ataques[ataqueElegido].efecto1 == "Aumentar Ataque Activo" || ataques[ataqueElegido].efecto2 == "Aumentar Ataque Activo")
                {
                    Console.WriteLine("El ataque de {0} ha aumentado.", nombre);
                    Console.ReadLine();
                    ataque = ataque + 15;
                }
                if (ataques[ataqueElegido].estadoEfectuado == "Dormir Activo")
                {
                    estado = "Dormido";
                }
                if (ataques[ataqueElegido].estadoEfectuado == "Paralizar Activo")
                {
                    estado = "Paralizado";
                }
                if (ataques[ataqueElegido].estadoEfectuado == "Confundir Activo")
                {
                    estado = "Confundido";
                }
                Estamina = Estamina - ataques[ataqueElegido].coste;
                return ataques[ataqueElegido];
            }
        }
        public void descansar()//La acción de descansar no infringe daño al bitmon enemigo, pero aumenta la estamina del 
        {                      //bitmon actual y además la defensa.
            Estamina += 10;
            defensa += 10;
        }

    }
}
