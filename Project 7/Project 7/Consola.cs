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
                    break;
                }
            }
        }
        public int elegirAtaque(Ataque[] ataquesBitmonActivo)
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
                    break;
                }
            }
        }
        public int elegirBitmon(Bitmon[] bitmons)
        {
            for (int i = 0; i < bitmons.Length-1 ; i+=1)
            {
                Console.WriteLine("Numero Actor : [{0}]", i);
                Console.WriteLine("Nombre Ataque: {0}", ataque.nombre);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  | Potencia | {0}", ataque.potencia);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  | Coste | {0}", ataque.coste);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  | Tipo | {0}", ataque.tipo);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  | Efecto1 | {0}", ataque.efecto1);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  | Efecto2 | {0}", ataque.efecto2);
                Console.WriteLine("  ==========================================");
                Console.WriteLine("  |Modificador de estado| {0}", ataque.estadoEfectuado);
                Console.WriteLine("  ==========================================");
                

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
                    break;
                }
            }
            return 1;
        }
    }
}
