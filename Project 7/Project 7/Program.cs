﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Project_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Consola.PantallaInicio();
            Juego juego = new Juego();
            Console.ReadKey(true);
        }
    }
}
