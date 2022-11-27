using System;
using System.Collections.Generic;
using System.Text;

namespace Retos_de_Programacion.Otros_Ejercicios.Ejercicio1
{
    class Solucion2
    {
        public static string FindDay(int DayNumber)
        {
            string Day;   
            
            switch (DayNumber)
            {
                case 1:
                    Day = "Monday";
                    break;
                case 2:
                    Day = "Tuesday";
                    break;
                case 3:
                    Day = "Wednesday";
                    break;
                case 4:
                    Day = "Thursday";
                    break;
                case 5:
                    Day = "Friday";
                    break;
                case 6:
                    Day = "Saturday";
                    break;
                case 7:
                    Day = "Sunday";
                    break;

                default:
                    Day = "Error, invalid value";
                    break;
            }

            return Day;
        }
    }
}
