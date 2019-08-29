//Autor:        Kroll
//Datum:        29.08.2019
//Dateiname:    main.cs
//Beschreibung: Hauptprogramm

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BruchRechner_Kroll
{
    public partial class main
    {
        private static int ersterZaehler;
        private static int ersterNenner;
        private static int zweiterZaehler;
        private static int zweiterNenner;
        public static string Rzeichen;
        public static void EingabeAnnehmen()
        {
            Console.WriteLine("Gebe deine Rechnung ein.");
            Console.WriteLine("Beispiel: 2/3 + 5/8");

            //TODO: Kommentieren
            Regex regEx = new Regex(@"((\d+)(?:/)(\d+)) (\*|\/|\+|\-) ((\d+)(?:/)(\d+))", RegexOptions.Multiline);
            string input = Console.ReadLine();
            Match match = regEx.Match(input);
            GroupCollection data = match.Groups;
            List<string> matches = new List<string>();

            if (match.Success)
            {
                foreach (string groupName in regEx.GetGroupNames())
                {
                    matches.Add(match.Groups[groupName].Value);
                }
                ersterZaehler = Convert.ToInt32(matches[2]);
                ersterNenner = Convert.ToInt32(matches[3]);
                Rzeichen = matches[4].ToString();
                zweiterZaehler = Convert.ToInt32(matches[6]);
                zweiterNenner = Convert.ToInt32(matches[7]);
            }
            else
            {
                Console.WriteLine("falsche Eingabe, beachte das Beispiel"); // Bei falscher Eingabe noch einmal eine Eingabe erfragen
                EingabeAnnehmen();
            }
        }
    }

}