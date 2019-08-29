//Autor:        Kroll
//Datum:        29.08.2019
//Dateiname:    main.cs
//Beschreibung: Gibt das Ergebnis aus

using System;

namespace BruchRechner_Kroll
{
    public partial class main
    {
        public static void GebeErgebnisAus()
        {
            Console.WriteLine("Das Ergebnis lautet: ");
            Console.WriteLine(Convert.ToString(ergebnisZaehler) + "/" + Convert.ToString(ergebnisNenner)); 
        }
    }

}