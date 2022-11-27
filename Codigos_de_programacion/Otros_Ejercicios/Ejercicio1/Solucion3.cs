using System;
using System.Collections.Generic;
using System.Text;

namespace Retos_de_Programacion.Otros_Ejercicios.Ejercicio1
{
    class Solucion3
    {
        public static string FindDay(int DayNumber)
        {
            string Day = DayNumber switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Error, invalid value",
            };
            return Day;
        }
    }
}
