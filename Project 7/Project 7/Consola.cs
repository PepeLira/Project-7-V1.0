using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Consola
    {
        public int preguntarAccionTurno(string nombreJugador)
        {
            Console.Write("Turno de {0}, desea:\n [0] Atacar\n [1] Descansar\n [2] Cambiar Actor\n", nombreJugador);
            while (true)
            {
                string imput = Console.ReadLine();
                int imputInt;
                if (!int.TryParse(imput, out imputInt))
                {
                    Console.WriteLine("{0} is not an integer", imput);
                    // Whatever
                }
                else
                {
                    return (imputInt);
                }
            }
        }
        public int elegirAtaque(List<Ataque> ataquesBitmonActivo)
        {
            int cont = 0;
            foreach (Ataque ataque in ataquesBitmonActivo)
            {
                Console.WriteLine("Indice : [{0}]",cont);
                Console.WriteLine("Nombre Ataque: {0}", ataque.nombre);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  | Potencia | {0}", ataque.potencia);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  | Coste | {0}", ataque.coste);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  | Tipo | {0}",ataque.tipo);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  | Efecto1 | {0}",ataque.efecto1);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  | Efecto2 | {0}",ataque.efecto2);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  |Modificador de estado| {0}",ataque.estadoEfectuado);
                Console.WriteLine("  ==========================================");
                cont += 1;

            }
            while (true)
            {
                string imput = Console.ReadLine();
                int imputInt;
                if (!int.TryParse(imput, out imputInt))
                {
                    Console.WriteLine("{0} is not an integer", imput);
                    // Whatever
                }
                else
                {
                    return (imputInt);
                    
                }
            }
        }
        public int elegirBitmon(Bitmon[] bitmons)
        {
            for (int i = 0; i < bitmons.Length-1 ; i+=1)
            {
                if (bitmons[i].hp != 0)
                {
                    Console.WriteLine("Numero Actor : [{0}]", i);
                    Console.WriteLine("Nombre Actor: {0}", bitmons[i].nombre);
                    Console.WriteLine("  ==========================================");
                    Console.WriteLine("  | Tipo | {0}", bitmons[i].tipo);
                    Console.WriteLine("  ==========================================");
                    Console.WriteLine("  | HP | {0}", bitmons[i].hp);
                    Console.WriteLine("  ==========================================");
                    Console.WriteLine("  | Estamina | {0}", bitmons[i].Estamina);
                    Console.WriteLine("  ==========================================");
                    Console.WriteLine("  | Ataque | {0}", bitmons[i].ataque);
                    Console.WriteLine("  ==========================================");
                    Console.WriteLine("  | Defensa | {0}", bitmons[i].defensa);
                    Console.WriteLine("  ==========================================");
                    Console.WriteLine("  | Velocidad | {0}", bitmons[i].velocidad);
                    Console.WriteLine("  ==========================================");
                    Console.WriteLine("  | Estado | {0}", bitmons[i].estado);
                    Console.WriteLine("  ==========================================");
                }
                else // "debe mostrar a los bitmons del equipo que no estén exhaustos." estos son los Bitmons muertos... recordar poner estado Fuera de Combate
                {
                    Console.WriteLine("Numero Actor : [{0}]", i);
                    Console.WriteLine("Nombre Actor: {0}", bitmons[i].nombre);
                    Console.WriteLine("  ==========================================");
                    Console.WriteLine("  | Estado | {0}", bitmons[i].estado);
                    Console.WriteLine("  ==========================================");
                }

            }
            while (true)
            {
                string imput = Console.ReadLine();
                int imputInt;
                if (!int.TryParse(imput, out imputInt))
                {
                    Console.WriteLine("{0} is not an integer", imput);
                    // Whatever
                }
                else
                {
                    return (imputInt);
                    
                }
            }
            
        }
    }
}
