using System;
using System.Collections.Generic;
using System.Text;

namespace Retos_de_Programacion.Otros_Ejercicios.Ejercicio1
{
    class Solucion4
    {
        

        public static string FindDay(int DayNumber)
        {
            string[] Days = new string[]
            {
                "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday",
            };

            if (DayNumber<1 || DayNumber > 7)
            {
                return "Error, invalid value";
            }

            return Days[DayNumber - 1];
        }

    }
}
