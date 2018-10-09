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
            Console.WriteLine("Elige un actor");
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
                            else if (resp == "n" ||  resp == "no")
                            {
                                Console.WriteLine("Elige un actor");
                                input = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("{0} no es una eleccion valida.", resp);
                                continue;
                            }
                        } 
                    Console.WriteLine("Actor fuera de rango.Introducelo de nuevo.");
                }
            }
        }
        public void mostrarEquipos(Jugador jugador1, Jugador jugador2)
        {

            Console.WriteLine("Equipo del Jugador 1");
            for (int i = 0; i < jugador1.bitmons.Length; i += 1)
            {
                Console.WriteLine("Numero Actor : [{0}]", i);
                Console.WriteLine("Nombre Actor: {0}", jugador1.bitmons[i].nombre);
                Console.WriteLine("  ==========================================");
            }
            Console.WriteLine("Equipo del Jugador 2");
            for (int i = 0; i < jugador2.bitmons.Length; i += 1)
            {
                Console.WriteLine("Numero Actor : [{0}]", i);
                Console.WriteLine("Nombre Actor: {0}", jugador2.bitmons[i].nombre);
                Console.WriteLine("  ==========================================");
            }
            Console.ReadKey();
            System.Console.Clear();
        }

        public int preguntarAccionTurno(string nombreJugador)
        {
            
            while (true)
            {
                
                Console.WriteLine("Turno de {0}, desea:\n [0] Atacar\n [1] Descansar\n [2] Cambiar Actor\n", nombreJugador);
                string imput = Console.ReadLine();
                System.Console.Clear();
                int imputInt;
                if (!int.TryParse(imput, out imputInt))
                {
                    Console.WriteLine("{0} is not an integer", imput);
                    // Whatever
                }
                else
                {
                    
                    if(imputInt == 0)
                    {
                        Console.Write("{0} a elegido :", nombreJugador);
                        Console.WriteLine("Atacar");
                        return (imputInt);
                    }
                    else if (imputInt == 1)
                    {
                        while (true)
                        {
                            Console.WriteLine("Estas seguro de Descansar?(y/n)");
                            string resp = Console.ReadLine();
                            if (resp == "s" || resp == "y" || resp == "si" || resp == "yes")
                            {
                                Console.WriteLine("{0} a elegido :", nombreJugador);
                                Console.WriteLine("Descansar");
                                return (imputInt);
                            }
                            else if (resp == "n" || resp == "no")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("{0} no es una eleccion valida.", resp);
                                continue;

                            }
                        }
                        
                    }
                    else if (imputInt == 2)
                    {
                        Console.WriteLine("{0} a elegido :", nombreJugador);
                        Console.WriteLine("Cambiar Actor");
                        return (imputInt);
                    }
                    else
                    {
                        Console.WriteLine("{0} no es una eleccion valida.", imputInt);
                        continue;
                    }
                    
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
                    return (imputInt);
                }
                else
                {
                    Console.WriteLine("{0} a elegido atacar con :", nombreJugador);
                    Console.WriteLine("{0}", ataquesBitmonActivo[imputInt].nombre);
                    System.Console.Clear();
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
            while (true)
            {
                string imput = Console.ReadLine();
                System.Console.Clear();
                int imputInt;
                if (!int.TryParse(imput, out imputInt))
                {
                    Console.WriteLine("{0} is not an integer", imput);
                    // Whatever
                }
                else if (imputInt == 9)
                {
                    return (imputInt);
                }
                else if(imputInt == 0 || imputInt == 1 || imputInt == 2)
                {

                    Console.WriteLine("{0} a elegido a:", nombreJugador);
                    Console.WriteLine("{0}",bitmons[imputInt].nombre);
                    return (imputInt);    
                }
                else
                {
                    Console.WriteLine("{0} no es una eleccion valida.", imputInt);
                    continue;
                }
            }
            
        }
        public void MostrarBitmonsActivos(Jugador jugador1, Jugador jugador2)
        {
            System.Console.Clear();
            Console.WriteLine("=================== Actores Nominados ================");
            Console.WriteLine("Pelicula de {0}", jugador1.nombre);
            Console.WriteLine("Nombre Actor: {0}", jugador1.BitmonActivo.nombre);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Tipo | {0}", jugador1.BitmonActivo.tipo);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | HP | {0}", jugador1.BitmonActivo.hp);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Estamina | {0}", jugador1.BitmonActivo.Estamina);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Ataque | {0}", jugador1.BitmonActivo.ataque);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Defensa | {0}", jugador1.BitmonActivo.defensa);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Velocidad | {0}", jugador1.BitmonActivo.velocidad);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Estado | {0}", jugador1.BitmonActivo.estado);
            Console.WriteLine("  ==========================================");
            Console.WriteLine();
            Console.WriteLine("Pelicula de {0}", jugador2.nombre);
            Console.WriteLine("Nombre Actor: {0}", jugador2.BitmonActivo.nombre);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Tipo | {0}", jugador2.BitmonActivo.tipo);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | HP | {0}", jugador2.BitmonActivo.hp);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Estamina | {0}", jugador2.BitmonActivo.Estamina);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Ataque | {0}", jugador2.BitmonActivo.ataque);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Defensa | {0}", jugador2.BitmonActivo.defensa);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Velocidad | {0}", jugador2.BitmonActivo.velocidad);
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  | Estado | {0}", jugador2.BitmonActivo.estado);
            Console.WriteLine("  ==========================================");
            Console.WriteLine();
        }

        public static void PantallaInicio()
        {
            Console.Write(@"OOOOOOOOOOOKXXNNXXKK0xodooodooooooooooodooooooooolllllccc::::;;;;;;;;,,,,,,,,,,cOOdl:cdxkkodOOkxkOOO
OOOOOOOOOOOKNNNNNXKK0xoooolc:;,,'''''''''''',,,,;;;:::;;;;;;;;;;;;;;,,,,,,,,,,,cOOdo;'cxkOddOOkdkOOO
OOOOOOOOOOOKNNNXXXKKOdol:;'..                        ......'''',,,;;;,,,,,,,,,,cOOdo;.;dxOxdkOxdkOkk
OOOOOOOOOOk0XXXXXX00kc;..                                     ....',,,,;;,,,,,,cOOdl;.,oxOkdkOxdxkkk
OOOOOOOOOOk0XXXXXXKO:..                                          ...'',,,,,,,,,cOOdc,.'oxOkdkOkxkkkk
OOOOOOOOOOk0XXXXXK0x'                                               ....'',,,,,cO0xoc'.lxkOxxOxxkkkk
OOOOOOOOOOk0XXXXXKOl.                                                   ..',,,,c00xdl,'cdxOxxOxxkkkk
OOOOOOOOOOk0XXXXXKOl.        . .....................................     ...',,l0Kxdo,.:dxkxdOxxkOOO
OOOOOOOOOOk0XXXXXKk:.    ......',;;;,,'....'.';:ccllllloolc:;,,,:;;,,.........'lK0xod:.'oxkkdkxxOOOO
OOOOOOOOOOk0XXXXX0x,  ...',;'.;coolcc:'..,:loxxkkkkkkkkkkkkkkxddddddol:,......;kK0xod:..oxkOdxkkOOOO
OOOOOOOOOOk0XNXNX0d....,;cll,'ldddllo;..;oxkOOOOO00OOO00OOOOOOOOOkkkxddoc,....l0K0xod;..lxkOxxkkOOOO
OOOOOOOOOOkOXXXNX0c..',:llodc':ollodl..:xOOOO00000000000000OO00OOOkkkxddolc,..oKK0xod:..:xxOkkkkOOOO
OOOOOOOOOOk0XXXNXO:.,;:llooooc;;:lxx;.,lxOOOO000000000000000000OOOOOOkxddoodc'dKKOdooc'.;dxOOkxxkOOO
OOOOOOOOOOk0XXXNXd'';:cclodoool;;col,;odxkO00KK0000000000000000OOOOOOkkxdoloxoxKKOdooc,.'ldkOkxxkOOO
OOOOOOOOOOkOXXXNKc..,;:clooooolcolc,'lkkkOKKKKKKK00000000K00000OOOOOOOkkxdolloOK00xolc;...:k0kxxOOOO
OOOOOOOOOOO0XXXNO,...',:clooodooddx:'oOOO0KXXXKK0000K000KK00000OOOOOOkkkkxol:l0K0Kkolc:'..,x0kkkOOOO
OOOOOOOOOOO0XNXNO, ...',:cllooodxxd:':xkk00KXXK00000K0000K0000OOOOOOkkkkkxdoclOK00kdllc,..'oOOxxOOOO
OOOOOOOOOOkOXXXNO' ....',:clloodxxkl:lokO00000OOO00000OO000OOOOOOOOkkkkkkxxdllOK0Okdoll;..'cOOxxkOkk
OOOOOOOOOOO0XXXXx.   ..',;:cclodxkko:odxKKKKKK000000OOOOO00OOOOOOOOOOOkkkxxdolxK00kdool:'.':xOxxkkkk
OOOOOOOOOOOOXXXXo.   ...,;::cloddxdl;ldxO0KKKKK0000OOOOOO0000OOOOOOOOOOOOkkxdld000kdolllc,';d0kxkOOO
OOOOOOOOOOkOXXXKc.   ...,::cllodxxxdc:ooxO00KKKK000000OOO000OOkkOOOOOOOOOkkxdloO0Oxdolllc,,,lOkxkOOk
OOOOOOOOkOkOXXXK:.  ...',;:cloddddxxoclodkkkOOOOOkkOOOOkkOOOkkxxxkkOOOOOkkkxdooxOOxdllllc;:;ckkxkOOk
OOOOOOOOkOkOXXX0:....',,;;;cloc:;;;;:;,,;ccccccloolllodxxxxxddocloooodxdooc:;;cxOOkxoollc:c;ckkxkOkk
OOOOOOkkOOkOKXX0:.'',,;;;;;;;,.......... .......',,,,;:lllllc::;,,,'..'........lOOkxolllc:l::xkxkOOk
kOOOOkkkOOkOXXX0c,;;;;;,,'...  ......           ......';::;;,,,....     ...''..:xOkkollll:docxkxkOOO
kOOOOOOOOOkOXXXKdc::;,,,'..    .........            ..,clll:'...........'',''..cOOOkollllcxxdkkxkOOO
OOOOOOOOOOO0XXXKko::;;,'..          ..',,.        ...'cdkxdl,.........'... ....lOOOxollolcxOkOkxkOOO
OOOOOOOOOOO0XXXKOd:;;,'..       ...';ldxd;.....'....',ldkOkd:.....';coo;. .   .cOOOxoololcdOkOkkOOOO
OOOOOOOOOOOOKXX0OOd:;;,'.....'',;;:lllool:,'',;:;,,,,:ldxkkkollcc:coool:,;;,'..lOOkxollolcdOOOkkOOOO
OOOOOOOOOOOOKNX0OKkc:::ccc::::;;;,;;::::;,,'',:cc::cccloxkOkxolllccccccccc:::::x0OOxolldocxOOOkkOOOO
OOOOOOOOOOOOKNX00Kklcccllcccloooolcc::::::coooolllllllcldxkOkdooolc;;;,,;:codolk00OxllodocxOkOkkOOOO
OOOOOOOOOOOOKNKO00xc::::cclloodxkkOkkkkkkkkOkkxoollllllloxO00OxodxxxxdddxkOOkdok0OOxllodocxOkOkkOOOO
OOOOOOOOOOOOKNKO0Oo:;;:cclllooddxkkO000000OOkkxolllllllodk0K00kdoodxkkkOOOOOkddk0OOxolodocxOOOkkOOOO
OOOOOOOOOOOOKXKO0kl;;;cclooooddxxkO0000K00kxdoooddxxxoodxOKK000kdddooxxkkkkkkdx00kOkllodolxOOOkkOOOO
OOOOOOOOOOOOKXKOOd:;;;:cclooddxxxkkOOOkxo:,'',:lccccc:;:coxkkkkdool:,;coxxkkkdx0OkOkllodolxOOOkkOOOO
OOOOOOOOOOOO0XKOxc',;,;:cclloodddxxxdo:,..........    ....,,;:;'...'...;codxxdOK0O0kloodolxOOOkkOOOO
OOOOOOOOOOOk0XKOd,.',,,;;::clllllolc:,.........  ....       ...  ..';'..,coddx0KK00kolodolxOOOkxOOOO
OOOOOOOOOOOk0XKOd;..''',,;;::::::::,...................         ...,;,'.';clld0KK00kolodocxOOOkxOOOO
OOOOOOOOOOOO0XKkxc....','',,,,,;;,'.....................       ..........';ccd0K000xolldlck0OOkxOOOO
OOOOOOOOOkOO0X0kxl.....'''''.''''.........................................,::dKK000xccldlck0OOkxkOOO
OOOOOkkOOkkk0X0xdo'.....',''''''..........................................,;;dXK0OOxllldock0OOkxkOOO
OOOOOOkkOkOk0X0xdd,......','',,,'.....'...  ..:;:odlcddllxxoddol' ........,,,dXK0OOkolldock0OOxxkOOO
OOOOOOOOOkkO0X0xdd, .....'''';::,.......   ..'lookOxxkOkO0OkOkdl.  ......,:;,xX0OOOkolldolk0OOxxkOOO
kOOOOOOOOkOO0XOodd, ........',:c:,,;,,'.   .......'.',;,,;,'....  ..,,,;:cc,,kXOO0Oxllldock0OOxxkOOO
kOOOOOkkkkkk0XOddd,  . ......';clccccc:,.',.............. .....''..';:::lc:.,OXOO0Oxlcldlck0OOkkOOOO
kOOOOOkkkkkk0Xkddd,     ......,:llllolc;:okOxdoloolodlllccloodkkl'';;:cccc;.;0X000Okolldlck0OOkxOOOO
kOOOOOOkkkkk0Xkodd'     .......':lllodoc:cldkO00K0xk0OkkkkkkkOOd:,cc;clol:..:0XK0OOxllldlck0OOkxOOOO
kkOOOOOkkkkkOKxdxl.       .......;clllool:;;clodkxdxxdddddddooocccc:ccloc'..;OX00Okxllldlck0OOkkOOOO
kkOOOOkkkkkkO0xoo;.         ......;ccclooc:;;;::loddxddooloolllc::::lccc;.. ;OXK0Okxolldlck0OOkkOOOO
kOOOOOkkkkkk0Oddo,.            ....;clclllc:;,,,,;;::cc::cc:;,,,,;:cc:;'.. .:0XKOkkxoccolck0OOkkOOOO
kkOOOkkkkkkO0kddo;.              ...,;:clool:;,,,,,,''',,,,'',,;:cll:;,..  .:0X0Okxdlccoc:xOOOkkOOOO
kkOOkkkkkxxO0kddo:.                ...,;:looolc::cc:;;,,,',,;:clllol:,'.   .lKKOOkxdlc:oc:xOOkkkOOOO
kkOOOkkkkxxOKOkdo:.                  ..';;:cldoooodooolllc:clllllclc;'.   .;xKX0Okxdl::lc:xOOkxxOOOO
kkOOOkkkkkkOKOdol'                     ...',:clloodoooddolooooollc:;'.    .oOKX0Okkdl::l::xOOkxxOOkk
kkkOOkkkkkxk0Oooc.                       ....',;:clc:::::cllccc:::,..     'xKXX0Okkdc::l::xOOkxxkkkk
kkkkkkkkkkkkOkoo:.                           ....'''''''.''',;,'...       .dXXX0OOkdc:coc:xOOkkxkkkk
kkkkkkkkxxkOOxloc.                                ...............         ;OXXKOkkkdc:coccxOkkxxkkkk
kkkkkkkkkkxkOxloc.                                                        .dKKKOkxkdc:coooxkkxxxkkkk
kkkkkkkkkxxkOdloc.                                                         'd0X0kxkdcccoccxkkxdxkkkk
xkkkkkkkkxxkOxldc.                                                         .,kKOkxxoccco::xkkxdxkkkk
kkkkkkkkkxxkkdoxo.                                                         ,dk0Okxxo:ccoc:xkkxdxkkkk
kkkkkkkkkxxxkxdko.                                                        .oXK0kxxxo::cl::xkxxddkkkk
kkkkkkkkxxxkOxdOo.                                                        .oXXKOkxdl::cl::xxxxodxkxk
kkkkkkkkxxxkkoxOl.                                                        .dXXKOkddo::cl;:xxkxooxxxx
kkkkkkkkxxdkOxkOc.                    ..                                  .xXKKkxddo:;cl;:xkkxooxxxx
kkkkkxxxxxdkOxkkl.                     ..                                 .xXKKOxddoc:co::xkkxoodxxx
kxkkxxxxxxdkOxkko.                      .                                 ,kXK0Oxodo::cl::dkkxoodxxx
xxxxxxxxxddkOxkko.                          ...                          .l0XKKOdodo:::l;:dkxxdoxxxx
xxxxxxxxxddkkdxOx'                         ......                        ,kXKKKOxxdo;;:l;:xkxxddxkxx
xxxxxxxxdddkkdkOl.                          .......                 .''.,dKXKK0kkxxo;;:l;;dkxxddxkxx
xxdxxxxxdddkxxOkc.                          ......                  .x0O0KXXXKKkxxxo:;:c,;dxxxddxxxx
xxdxxxdddddxxxOOo.                          .....                   .d0KXKXXXK0kxxdl;;cc,:dxxdooxxxx
dxxxxxddddodxxkOd.                         ......                   ,x0KXKXXKK0xdddo:::c;:dxxdloxxxx
ddxxxxxxddoxkxkOd.                          .....                   ,kKKXXXXXK0dooodl:cc,:dxxdloxxxx
xxxxxxxxxddxkxkOo.             ..           ....                    'kKXXXXXXK0xddddc::c;cxxxdodxxxx
xxkkkkkkkxdxkxkOo.             ..            ..                     .dKXXXXXXXKOxodo:;:c;cxxxdodkxxx");
            Console.ReadKey(true);
            System.Console.Clear();
            Console.CursorLeft = (Console.WindowWidth / 2 - "BOLLYWOOD SHOWDOWN".Length / 2);
            Console.CursorTop = (Console.WindowHeight / 4);
            Console.Write("BOLLYWOOD SHOWDOWN");//titulo tentativo
            Console.CursorLeft = (Console.WindowWidth / 2 - "Presione cualquier tecla para continuar".Length / 2);
            Console.CursorTop = (Console.WindowHeight * 3 / 4);
            Console.Write("Presione cualquier tecla para continuar\n");
            Console.ReadKey(true);
            Console.Clear();
        }

        public void pantallaGanador(Jugador jugadorGanador)
        {
            System.Console.Clear();
            Console.WriteLine(@"                                     ...                                                                                                              
                         .           ...                .                                                                                             
                         ..          ...              ...          ..                                                                                 
        .                ...        ....             ....        ....                                                                                 
        ...              ...        ...,;'.          ....      .....                                                                                  
        ....             ....       .,d00k:.        .....     ......                                                                                  
         ....            .....      .lO0Okd'       ......    ......                                                                                   
         .....           .....      .ck0Oko.      .......   .......                                                                                   
          .....          ......   ...,lxkd;.     .......   .......                                                                                    
           .....         ........  ..,okko,..   ..................                                                                                    
           .......      .......,;:clxO0000kl:,....................                           ....                                                     
           ..................,d0OOKXXXK0KXK000Oxdc'...............                        ......                                                      
           ..................,oOOO0XXKOxkKOkkkkkkx:................               .............                                                       
..   . .. ...................,d00OO0000Ok00kdodO0d,.................         .................                                                        
...... ......................,dkxOKKKKK0OOkxkkk0Kd;..........................................                                                         
.............................'cdk0KKKK00OkxdxO00xc,.........................................             ....                                         
.............................';oO000KKK0Okkkkkk0Oc'........................................            ....                                           
..............................':ldkO00OOkO0kxoclc,......'................................           ......                                            
...................'..........''.;xkxdxkolool;..''.....''...................................    ........                                              
...................''.........'''lOkxdOOl;:lo;.'''....'''................................... .........       Felicidades Jose has ganado un Oscar, Gracias por Jugar!!!                                         
.....''.............''........'';xX0kkkkl:oxkl''''...',''............................................                                                 
.....''''...........','.......',:kNX0kkkooO00d,,,'.'',,'............................................                                                  
.......',''..........','......',cOXK0kkxdx00Kk;,'''',,,.................''''.......................                                                   
.......'',,''.........,,,.....',cOXKOO0kdOKO0k:,'',,,,'...........''''''''............................                                                
........'',,,'........',,'....',ckK0xkKkd00xkx:,,,,;;,'........''''''',''...............................                                              
.........'',;;,'.......,;;,'..',:lxkod0kdOklll:,,;;;;'.......''',,,,,,''.................................                                             
...........',;;;,'.....';;;,'.',;:loclOkoxo:::;,;::;,'....''',,,,,,,,'..........''........................                                            
............';::;,''...',;:;,'',;:coooOkodl:c:;;:::;'..''',,,;;;;;;,'........''''.............................                                        
''..........'',:c:;,''''';::;,',;coO000kdkdol:::cc;,'''',,;;;;:;;;,'.....''',''..........................................                             
,,,''........'',:cc:;,''',:c:;,,;cdO0xxxoddxo::cc:;'',,,;;:::::;,,'..''',,,''.............................................................            
',,;,,,''.....'',:clc:;,,,;ccc;,;cd0Ooddodxklcclc:,,,;;::cccc:;,'''',,;,,'................................................................            
''',,;;;;,'''.'',,:colc:;,;:clc;;cdO0dxddxkkolllc;;;::cclllc:;,,,,,;;;,'..............................................................                
,'''',;;::;;,'''',,:loolc:;;cooc:ldOOxxddkOxoool:::cclloolc:;,,;;:;;,''...............................................................                
,,,,,,,,;;::::;,,,,;:loddlc:cldollokOxxddkkxddoccclooodolc:;;::::;,'''.........................................................................       
'',;;;;;;;;::ccc:;;;;:loxxdlcldxdooxkxxodkxxxdollodddddlc::ccc::;,''''''....................'''''''.............................................      
...'',;;::::::clllcc::cldxkxdodxxddxkxxodkxkkdddxxkxxdllllllc:;,,,,''''''''''''''''',,,,,,,''''''''...........................................        
.....'',,;:cccccllooolllldkOOkxxOOxxOOkdkOOOkxkkOOkxdoooolc:;;;,,,,,,,,,,,,,,,,;;;;;;;,,,,,,'''''............................................         
''''''''',,;:cllllooddddddxO00OOO0OO000O0KK0OO0000kxxddolc::::;;;;;::::::::::::::;;;;;,,,,'''''............................................           
'',,,,,,,,,,;;::cooddxxkkxddxkkOO0KKKK00K0Okxxdxxxxkxdoolllccccccllllllcccccc:::;;;;,,,,,'''''''''...................................                 
''',,,;;;;:::::ccclodxkkOdcdddxxkkxxdooooooooddkOOxodxdddddddddddoooollccc::::;;;;;,,,,,,,''''''.....................................                 
,,,,,,;;;:::cclloooddxxkdc,,.......          ...,ccldkOOOkkkxxxddoolllccc:::::;;;;;,,,,,'''''...........................................              
;;;;;:::::cccllodddxkkx:.                           .;k00Okkxxddoolllccc::::;;;;,,,,'''''...................................................          
ccccccllllooodddxxkkO0x.                              l0OOkxxddoolllcc::::;;;;,,,,,''''''''......................................................     
ccccllloooddxxxkkkO00K0,                             .d0OOkkxxdddooolllccc:::::::;;;;;,,,,,,''''''''..................................................
:::ccccllloodddxxkkO0K0:         .                   'kK0OOkkxxxdddooollllcccccc:::::;;;;;;,,,,,''''''''..............................................
;;;;:::cccllooddxkkOO00;         .                .. ,k0Okkxxddooolllcccc::::::;;;;;;;,,,,,,,'''''''''................................................
;;:::cccllooodddxkkO0KO,                          .  'kK0Okkxdddoollcc::::;;;;;;,,,,,,'''''''.........................................................
::::cccccllooddxxkkkkx:.                             .lkOOkkkxxddoolllcc::::;;;;,,,,,''''''...........................................................
;;;:::cclloodddddddc'.                                ..;oxxddddddooolllccc::::;;;,,,,,'''''..........................................................
;;::ccllloooooolool.                                     ,oddoooooooollllcccc:::;;;;,,,,''''''........................................................");
            Console.WriteLine("oprima cualquier tecla para finalizar");
            
        }

    }
}
