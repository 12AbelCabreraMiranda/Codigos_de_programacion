using System;
using System.Collections.Generic;
using System.Text;

namespace Retos_de_Programacion.Otros_Ejercicios.Ejercicio1
{  
    public class Principal
    {
        //Ingresar un numero como parámetro para que el programa
        //nos devuelva el día de la semana.

        /*Con este ejercicio veremos como simplificar nuestro código*/
        
        public static void Inicio()
        {
            var result = Solucion4.FindDay(1);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        
    }
}
