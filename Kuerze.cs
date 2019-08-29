//Autor:        Kroll
//Datum:        29.08.2019
//Dateiname:    main.cs
//Beschreibung: Hauptprogramm

using System;

namespace BruchRechner_Kroll
{
    public partial class main
    {
        public static void Kuerze()
        {
            int ggTZaehler = ergebnisZaehler;
            int ggTNenner = ergebnisNenner;
            int ggT;

            if (ggTZaehler == 0)                    //ggT bestimmen
            {
                ggT = ggTNenner;
            }
            else
            {
                while (ggTNenner != 0)
                {
                    if (ggTZaehler > ggTNenner)
                    {
                        ggTZaehler = ggTZaehler - ggTNenner;
                    }
                    else
                    {
                        ggTNenner = ggTNenner - ggTZaehler;
                    }
                }
                ggT = ggTZaehler;
            }

            ergebnisZaehler = ergebnisZaehler / ggT;
            ergebnisNenner = ergebnisNenner / ggT;
        }
    }
}