//Autor:        Kroll
//Datum:        29.08.2019
//Dateiname:    main.cs
//Beschreibung: Hauptprogramm

using System;

namespace BruchRechner_Kroll
{
    public partial class main
    {
        public static void PruefeRechenzeichenUndRechneAus()
        {
            switch (Rzeichen)
            {
                case "*":
                    Multipliziere();
                    break;

                case "/":
                    Dividiere();
                    break;

                case "+":
                    Addiere();
                    break;

                case "-":
                    Subtrahiere();
                    break;
            }
        }
    }

}