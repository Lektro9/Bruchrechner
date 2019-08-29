//Autor:        Kroll
//Datum:        29.08.2019
//Dateiname:    main.cs
//Beschreibung: Hauptfunktion
//Änderungen:
//28.08.2019:   Entwicklungsbeginn,  
//29.08.2019:   

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BruchRechner_Kroll
{
    public partial class main
    {
        private static bool programmIsRunning = true;

        static void Main(string[] args)
        {
            ShowSplashScreen();

            while(programmIsRunning)
            {
                Console.Clear();

                Run();

                Console.WriteLine("Moechtest du weiterrechnen? Drücke n für nein");
                if (Console.ReadKey(true).Key == ConsoleKey.N)
                {
                    Console.Clear();
                    Console.WriteLine("Beende...");
                    Thread.Sleep(500);
                    programmIsRunning = false;
                }
                else
                {

                }
            }
        }
    }

}
