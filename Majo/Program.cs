using Majo.Controllers;
using System;
using System.Drawing;

namespace Majo
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length >= 0)
            {
                switch (args[0])
                {
                    case "help":
                        ImgToAscii.DrawMajo();
                        Help.messageHelp();
                        break;
                    case "clima":
                        Clima.printWeather();
                        break;
                    case "spfy":
                        switch (args[1])
                        {
                            case "play":
                            case "pause":
                                spfy.playPauseTrack();
                                break;
                            case "nxt":
                                spfy.nextTrack();
                                break;
                            case "bck":
                                spfy.nextTrack();
                                break;
                            default:
                                Console.WriteLine("No reconozco ese comando para Spfy");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Escribe 'Majo help' para ver las opciones");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Escribe 'Majo help' para ver las opciones");
            }
        }
    }
}
