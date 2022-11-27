using System;
using System.Collections.Generic;
using System.Text;

namespace Retos_de_Programacion.Otros_Ejercicios.Ejercicio1
{
    class Solucion1
    {
        public static string FindDay(int DayNumber)
        {
            string Day = "";

            if (DayNumber == 1)
            {
                Day = "Monday";
            }
            if (DayNumber == 2)
            {
                Day = "Tuesday";
            }
            if (DayNumber == 3)
            {
                Day = "Wednesday";
            }
            if (DayNumber == 4)
            {
                Day = "Thursday";
            }
            if (DayNumber == 5)
            {
                Day = "Friday";
            }
            if (DayNumber == 6)
            {
                Day = "Saturday";
            }
            if (DayNumber == 7)
            {
                Day = "Sunday";
            }
            if(Day == "")
            {
                return "Error, invalid value";
            }

            return Day;
        }
    }
}
