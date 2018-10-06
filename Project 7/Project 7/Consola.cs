using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Consola
    {
        public static string PedirNombre()
        {
            Console.WriteLine("Introduce tu nombre");
            string nombre = Console.ReadLine();
            return nombre;
        }

        public static int ElegirBitmon(List<Bitmon> bitmons)
        {
            Console.WriteLine("Elije un actor");
            while (true)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int eleccion))
                {
                    Console.WriteLine("{0} no es un numero.", input);
                    continue;
                }
                else
                {
                    if (eleccion > 0 && eleccion < bitmons.Count() + 1)
                        while (true)
                        {
                            Console.WriteLine("Estas seguro?(y/n)");
                            string resp = Console.ReadLine();
                            if (resp=="s"|| resp == "y"|| resp=="si"|| resp=="yes")
                            {
                                return eleccion;
                            }
                            else
                            {
                                Console.WriteLine("Elije un actor");
                                input = Console.ReadLine();
                                continue;
                            }
                        } 
                    Console.WriteLine("Actor fuera de rango.Introducelo de nuevo.");
                }
            }
        }

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
                    Console.Write("{0} a elegido :", nombreJugador);
                    if(imputInt == 0)
                    {
                        Console.Write("Atacar");
                    }
                    else if (imputInt == 1)
                    {
                        Console.Write("Descansar");
                    }
                    else if (imputInt == 2)
                    {
                        Console.Write("Cambiar Actor");
                    }
                    return (imputInt);
                }
            }
        }
        public int elegirAtaque(List<Ataque> ataquesBitmonActivo,string nombreJugador)
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
            Console.WriteLine("Para volver al menu anterior presiona 9:");

            while (true)
            {
                string imput = Console.ReadLine();
                int imputInt;
                if (!int.TryParse(imput, out imputInt))
                {
                    Console.WriteLine("{0} is not an integer", imput);
                    // Whatever
                }
                else if(imputInt == 9)
                {
                    //crear loop para volver al menu de opciones
                }
                else
                {
                    Console.Write("{0} a elegido atacar con :", nombreJugador);
                    Console.Write("{0}", ataquesBitmonActivo[imputInt]);
                    return (imputInt);
                }
            }
        }
        public int elegirBitmon(Bitmon[] bitmons,string nombreJugador)
        {
            for (int i = 0; i < bitmons.Length ; i+=1)
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
            Console.WriteLine("Para volver al menu anterior presiona 9:");
            while (true)
            {
                string imput = Console.ReadLine();
                int imputInt;
                if (!int.TryParse(imput, out imputInt))
                {
                    Console.WriteLine("{0} is not an integer", imput);
                    // Whatever
                }
                else if (imputInt == 9)
                {
                    //crear loop para volver al menu de opciones
                }
                else
                {
                    Console.Write("{0} a elegido a:", nombreJugador);
                    Console.Write("{0}",bitmons[imputInt].nombre);
                    return (imputInt);
                    
                }
            }
            
        }
    }
}
