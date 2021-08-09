using System;
using System.Collections.Generic;
using System.Text;

namespace Majo.Controllers
{
    static class Help
    {
        public static void messageHelp()
        {
            string text = @"
Escribe Majo mas un argumento
Argumentos:
Clima -> Te dira el clima actual
spfy -> Te permite dar Play/Pausa, siguiente canción o canción anterior
     -> play o pause
     -> nxt para la siguiente cancion
     -> bck para la cancion anterior ";
     


            Console.WriteLine(text);

        }
    }
}
