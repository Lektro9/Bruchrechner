//Autor:        Kroll
//Datum:        29.08.2019
//Dateiname:    main.cs
//Beschreibung: Hauptprogramm

using System;

namespace BruchRechner_Kroll
{
    public partial class main
    {
        private static int ergebnisZaehler;
        private static int ergebnisNenner;

        public static void Multipliziere()
        {
            ergebnisZaehler = ersterZaehler * zweiterZaehler;
            ergebnisNenner = ersterNenner * zweiterNenner;
        }

        public static void Dividiere()
        {
            ergebnisZaehler = ersterZaehler * zweiterNenner;
            ergebnisNenner = ersterNenner * zweiterZaehler;
        }

        public static void Addiere()
        {
            int ersterZwischenZaehler;
            int zweiterZwischenZaehler;

            ersterZwischenZaehler = ersterZaehler * zweiterNenner;
            zweiterZwischenZaehler = zweiterZaehler * ersterNenner;
            
            ergebnisZaehler = ersterZwischenZaehler + zweiterZwischenZaehler;
            ergebnisNenner = ersterNenner * zweiterNenner;
        }

        public static void Subtrahiere() //TODO: Ein Fehler entsteht wenn der erste Bruch größer ist als der Zweite
        {
            int ersterZwischenZaehler;
            int zweiterZwischenZaehler;

            ersterZwischenZaehler = ersterZaehler * zweiterNenner;
            zweiterZwischenZaehler = zweiterZaehler * ersterNenner;

            ergebnisZaehler = ersterZwischenZaehler - zweiterZwischenZaehler;
            ergebnisNenner = ersterNenner * zweiterNenner;
        }
    }

}