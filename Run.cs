//Autor:        Kroll
//Datum:        29.08.2019
//Dateiname:    main.cs
//Beschreibung: Hauptprogramm

using System;

namespace BruchRechner_Kroll
{
    public partial class main
    {
        public static void Run()
        {

            //1. Bruch einlesen
            EingabeAnnehmen();

            //2. Ausrechnen
            PruefeRechenzeichenUndRechneAus();

            //3. Kürzen
            Kuerze();

            //4. Ausgeben
            GebeErgebnisAus();
        }
    }
}