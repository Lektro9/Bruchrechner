//Autor:        Kroll
//Datum:        29.08.2019
//Dateiname:    main.cs
//Beschreibung: Zeigt den Splashscreen

using System;
using System.Threading;

namespace BruchRechner_Kroll
{
    public static partial class main
    {
        static public void ShowSplashScreen()
        {
            Console.Clear();

            Console.WriteLine(@" ___                        _      ___                  _                         
(  _`\                     ( )    |  _`\               ( )                        
| (_) ) _ __  _   _    ___ | |__  | (_) )   __     ___ | |__    ___     __   _ __ 
|  _ <'( '__)( ) ( ) /'___)|  _ `\| ,  /  /'__`\ /'___)|  _ `\/' _ `\ /'__`\( '__)
| (_) )| |   | (_) |( (___ | | | || |\ \ (  ___/( (___ | | | || ( ) |(  ___/| |   
(____/'(_)   `\___/'`\____)(_) (_)(_) (_)`\____)`\____)(_) (_)(_) (_)`\____)(_)   ");
            
            Console.WriteLine("\n           Programmm:    BruchrechnerV1.0");
            Console.WriteLine("           Autor:        Kroll");
            Console.WriteLine("           Beschreibung: Simples Rechnen mit Brüchen");
            Thread.Sleep(2000);
        }
    }
}
