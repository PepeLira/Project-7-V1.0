using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Menu
    {
        public static void PantallaInicio()
        {
            Console.Write(@"OOOOOOOOOOOKXXNNXXKK0xodooodooooooooooodooooooooolllllccc::::;;;;;;;;,,,,,,,,,,cOOdl:cdxkkodOOkxkOOO\n
OOOOOOOOOOOKNNNNNXKK0xoooolc:;,,'''''''''''',,,,;;;:::;;;;;;;;;;;;;;,,,,,,,,,,,cOOdo;'cxkOddOOkdkOOO\n
OOOOOOOOOOOKNNNXXXKKOdol:;'..                        ......'''',,,;;;,,,,,,,,,,cOOdo;.;dxOxdkOxdkOkk\n
OOOOOOOOOOk0XXXXXX00kc;..                                     ....',,,,;;,,,,,,cOOdl;.,oxOkdkOxdxkkk\n
OOOOOOOOOOk0XXXXXXKO:..                                          ...'',,,,,,,,,cOOdc,.'oxOkdkOkxkkkk\n
OOOOOOOOOOk0XXXXXK0x'                                               ....'',,,,,cO0xoc'.lxkOxxOxxkkkk\n
OOOOOOOOOOk0XXXXXKOl.                                                   ..',,,,c00xdl,'cdxOxxOxxkkkk\n
OOOOOOOOOOk0XXXXXKOl.        . .....................................     ...',,l0Kxdo,.:dxkxdOxxkOOO\n
OOOOOOOOOOk0XXXXXKk:.    ......',;;;,,'....'.';:ccllllloolc:;,,,:;;,,.........'lK0xod:.'oxkkdkxxOOOO\n
OOOOOOOOOOk0XXXXX0x,  ...',;'.;coolcc:'..,:loxxkkkkkkkkkkkkkkxddddddol:,......;kK0xod:..oxkOdxkkOOOO\n
OOOOOOOOOOk0XNXNX0d....,;cll,'ldddllo;..;oxkOOOOO00OOO00OOOOOOOOOkkkxddoc,....l0K0xod;..lxkOxxkkOOOO\n
OOOOOOOOOOkOXXXNX0c..',:llodc':ollodl..:xOOOO00000000000000OO00OOOkkkxddolc,..oKK0xod:..:xxOkkkkOOOO\n
OOOOOOOOOOk0XXXNXO:.,;:llooooc;;:lxx;.,lxOOOO000000000000000000OOOOOOkxddoodc'dKKOdooc'.;dxOOkxxkOOO\n
OOOOOOOOOOk0XXXNXd'';:cclodoool;;col,;odxkO00KK0000000000000000OOOOOOkkxdoloxoxKKOdooc,.'ldkOkxxkOOO\n
OOOOOOOOOOkOXXXNKc..,;:clooooolcolc,'lkkkOKKKKKKK00000000K00000OOOOOOOkkxdolloOK00xolc;...:k0kxxOOOO\n
OOOOOOOOOOO0XXXNO,...',:clooodooddx:'oOOO0KXXXKK0000K000KK00000OOOOOOkkkkxol:l0K0Kkolc:'..,x0kkkOOOO\n
OOOOOOOOOOO0XNXNO, ...',:cllooodxxd:':xkk00KXXK00000K0000K0000OOOOOOkkkkkxdoclOK00kdllc,..'oOOxxOOOO\n
OOOOOOOOOOkOXXXNO' ....',:clloodxxkl:lokO00000OOO00000OO000OOOOOOOOkkkkkkxxdllOK0Okdoll;..'cOOxxkOkk\n
OOOOOOOOOOO0XXXXx.   ..',;:cclodxkko:odxKKKKKK000000OOOOO00OOOOOOOOOOOkkkxxdolxK00kdool:'.':xOxxkkkk\n
OOOOOOOOOOOOXXXXo.   ...,;::cloddxdl;ldxO0KKKKK0000OOOOOO0000OOOOOOOOOOOOkkxdld000kdolllc,';d0kxkOOO\n
OOOOOOOOOOkOXXXKc.   ...,::cllodxxxdc:ooxO00KKKK000000OOO000OOkkOOOOOOOOOkkxdloO0Oxdolllc,,,lOkxkOOk\n
OOOOOOOOkOkOXXXK:.  ...',;:cloddddxxoclodkkkOOOOOkkOOOOkkOOOkkxxxkkOOOOOkkkxdooxOOxdllllc;:;ckkxkOOk\n
OOOOOOOOkOkOXXX0:....',,;;;cloc:;;;;:;,,;ccccccloolllodxxxxxddocloooodxdooc:;;cxOOkxoollc:c;ckkxkOkk\n
OOOOOOkkOOkOKXX0:.'',,;;;;;;;,.......... .......',,,,;:lllllc::;,,,'..'........lOOkxolllc:l::xkxkOOk\n
kOOOOkkkOOkOXXX0c,;;;;;,,'...  ......           ......';::;;,,,....     ...''..:xOkkollll:docxkxkOOO\n
kOOOOOOOOOkOXXXKdc::;,,,'..    .........            ..,clll:'...........'',''..cOOOkollllcxxdkkxkOOO\n
OOOOOOOOOOO0XXXKko::;;,'..          ..',,.        ...'cdkxdl,.........'... ....lOOOxollolcxOkOkxkOOO\n
OOOOOOOOOOO0XXXKOd:;;,'..       ...';ldxd;.....'....',ldkOkd:.....';coo;. .   .cOOOxoololcdOkOkkOOOO\n
OOOOOOOOOOOOKXX0OOd:;;,'.....'',;;:lllool:,'',;:;,,,,:ldxkkkollcc:coool:,;;,'..lOOkxollolcdOOOkkOOOO\n
OOOOOOOOOOOOKNX0OKkc:::ccc::::;;;,;;::::;,,'',:cc::cccloxkOkxolllccccccccc:::::x0OOxolldocxOOOkkOOOO\n
OOOOOOOOOOOOKNX00Kklcccllcccloooolcc::::::coooolllllllcldxkOkdooolc;;;,,;:codolk00OxllodocxOkOkkOOOO\n
OOOOOOOOOOOOKNKO00xc::::cclloodxkkOkkkkkkkkOkkxoollllllloxO00OxodxxxxdddxkOOkdok0OOxllodocxOkOkkOOOO\n
OOOOOOOOOOOOKNKO0Oo:;;:cclllooddxkkO000000OOkkxolllllllodk0K00kdoodxkkkOOOOOkddk0OOxolodocxOOOkkOOOO\n
OOOOOOOOOOOOKXKO0kl;;;cclooooddxxkO0000K00kxdoooddxxxoodxOKK000kdddooxxkkkkkkdx00kOkllodolxOOOkkOOOO\n
OOOOOOOOOOOOKXKOOd:;;;:cclooddxxxkkOOOkxo:,'',:lccccc:;:coxkkkkdool:,;coxxkkkdx0OkOkllodolxOOOkkOOOO\n
OOOOOOOOOOOO0XKOxc',;,;:cclloodddxxxdo:,..........    ....,,;:;'...'...;codxxdOK0O0kloodolxOOOkkOOOO\n
OOOOOOOOOOOk0XKOd,.',,,;;::clllllolc:,.........  ....       ...  ..';'..,coddx0KK00kolodolxOOOkxOOOO\n
OOOOOOOOOOOk0XKOd;..''',,;;::::::::,...................         ...,;,'.';clld0KK00kolodocxOOOkxOOOO\n
OOOOOOOOOOOO0XKkxc....','',,,,,;;,'.....................       ..........';ccd0K000xolldlck0OOkxOOOO\n
OOOOOOOOOkOO0X0kxl.....'''''.''''.........................................,::dKK000xccldlck0OOkxkOOO\n
OOOOOkkOOkkk0X0xdo'.....',''''''..........................................,;;dXK0OOxllldock0OOkxkOOO\n
OOOOOOkkOkOk0X0xdd,......','',,,'.....'...  ..:;:odlcddllxxoddol' ........,,,dXK0OOkolldock0OOxxkOOO\n
OOOOOOOOOkkO0X0xdd, .....'''';::,.......   ..'lookOxxkOkO0OkOkdl.  ......,:;,xX0OOOkolldolk0OOxxkOOO\n
kOOOOOOOOkOO0XOodd, ........',:c:,,;,,'.   .......'.',;,,;,'....  ..,,,;:cc,,kXOO0Oxllldock0OOxxkOOO\n
kOOOOOkkkkkk0XOddd,  . ......';clccccc:,.',.............. .....''..';:::lc:.,OXOO0Oxlcldlck0OOkkOOOO\n
kOOOOOkkkkkk0Xkddd,     ......,:llllolc;:okOxdoloolodlllccloodkkl'';;:cccc;.;0X000Okolldlck0OOkxOOOO\n
kOOOOOOkkkkk0Xkodd'     .......':lllodoc:cldkO00K0xk0OkkkkkkkOOd:,cc;clol:..:0XK0OOxllldlck0OOkxOOOO\n
kkOOOOOkkkkkOKxdxl.       .......;clllool:;;clodkxdxxdddddddooocccc:ccloc'..;OX00Okxllldlck0OOkkOOOO\n
kkOOOOkkkkkkO0xoo;.         ......;ccclooc:;;;::loddxddooloolllc::::lccc;.. ;OXK0Okxolldlck0OOkkOOOO\n
kOOOOOkkkkkk0Oddo,.            ....;clclllc:;,,,,;;::cc::cc:;,,,,;:cc:;'.. .:0XKOkkxoccolck0OOkkOOOO\n
kkOOOkkkkkkO0kddo;.              ...,;:clool:;,,,,,,''',,,,'',,;:cll:;,..  .:0X0Okxdlccoc:xOOOkkOOOO\n
kkOOkkkkkxxO0kddo:.                ...,;:looolc::cc:;;,,,',,;:clllol:,'.   .lKKOOkxdlc:oc:xOOkkkOOOO\n
kkOOOkkkkxxOKOkdo:.                  ..';;:cldoooodooolllc:clllllclc;'.   .;xKX0Okxdl::lc:xOOkxxOOOO\n
kkOOOkkkkkkOKOdol'                     ...',:clloodoooddolooooollc:;'.    .oOKX0Okkdl::l::xOOkxxOOkk\n
kkkOOkkkkkxk0Oooc.                       ....',;:clc:::::cllccc:::,..     'xKXX0Okkdc::l::xOOkxxkkkk\n
kkkkkkkkkkkkOkoo:.                           ....'''''''.''',;,'...       .dXXX0OOkdc:coc:xOOkkxkkkk\n
kkkkkkkkxxkOOxloc.                                ...............         ;OXXKOkkkdc:coccxOkkxxkkkk\n
kkkkkkkkkkxkOxloc.                                                        .dKKKOkxkdc:coooxkkxxxkkkk\n
kkkkkkkkkxxkOdloc.                                                         'd0X0kxkdcccoccxkkxdxkkkk\n
xkkkkkkkkxxkOxldc.                                                         .,kKOkxxoccco::xkkxdxkkkk\n
kkkkkkkkkxxkkdoxo.                                                         ,dk0Okxxo:ccoc:xkkxdxkkkk\n
kkkkkkkkkxxxkxdko.                                                        .oXK0kxxxo::cl::xkxxddkkkk\n
kkkkkkkkxxxkOxdOo.                                                        .oXXKOkxdl::cl::xxxxodxkxk\n
kkkkkkkkxxxkkoxOl.                                                        .dXXKOkddo::cl;:xxkxooxxxx\n
kkkkkkkkxxdkOxkOc.                    ..                                  .xXKKkxddo:;cl;:xkkxooxxxx\n
kkkkkxxxxxdkOxkkl.                     ..                                 .xXKKOxddoc:co::xkkxoodxxx\n
kxkkxxxxxxdkOxkko.                      .                                 ,kXK0Oxodo::cl::dkkxoodxxx\n
xxxxxxxxxddkOxkko.                          ...                          .l0XKKOdodo:::l;:dkxxdoxxxx\n
xxxxxxxxxddkkdxOx'                         ......                        ,kXKKKOxxdo;;:l;:xkxxddxkxx\n
xxxxxxxxdddkkdkOl.                          .......                 .''.,dKXKK0kkxxo;;:l;;dkxxddxkxx\n
xxdxxxxxdddkxxOkc.                          ......                  .x0O0KXXXKKkxxxo:;:c,;dxxxddxxxx\n
xxdxxxdddddxxxOOo.                          .....                   .d0KXKXXXK0kxxdl;;cc,:dxxdooxxxx\n
dxxxxxddddodxxkOd.                         ......                   ,x0KXKXXKK0xdddo:::c;:dxxdloxxxx\n
ddxxxxxxddoxkxkOd.                          .....                   ,kKKXXXXXK0dooodl:cc,:dxxdloxxxx\n
xxxxxxxxxddxkxkOo.             ..           ....                    'kKXXXXXXK0xddddc::c;cxxxdodxxxx\n
xxkkkkkkkxdxkxkOo.             ..            ..                     .dKXXXXXXXKOxodo:;:c;cxxxdodkxxx\n");
            Console.CursorLeft = (Console.WindowWidth /2 - "BOLLYWOOD SHOWDOWN".Length/2);
            Console.CursorTop = (Console.WindowHeight / 4);
            Console.Write("BOLLYWOOD SHOWDOWN");//titulo tentativo
            Console.CursorLeft = (Console.WindowWidth /2 - "Presione cualquier tecla para continuar".Length/2);
            Console.CursorTop = (Console.WindowHeight *3 / 4);
            Console.Write("Presione cualquier tecla para continuar\n");
            Console.ReadKey(true);
        }

        public static string PedirNombre()
        {
            Console.WriteLine("Introduce tu nombre");
            string nombre = Console.ReadLine();
            return nombre;
        }

        public static int ElegirBitmon()
        {
            Console.WriteLine("Elije un bitmon");
            while (true)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int age))
                {
                    Console.WriteLine("{0} is not an integer", input);
                    // Whatever
                }
                else
                {
                    return age;
                }
            }
        }
    }
}
