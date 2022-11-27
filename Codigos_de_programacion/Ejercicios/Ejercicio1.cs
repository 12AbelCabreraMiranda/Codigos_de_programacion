using System;
using System.Collections.Generic;
using System.Text;

namespace Retos_de_Programacion
{
    class Ejercicio1
    {
        /*
         * Escribe un programa que muestre por consola (con un print) los
         * números de 1 a 100 (ambos incluidos y con un salto de línea entre
         * cada impresión), sustituyendo los siguientes:
         * - Múltiplos de 3 por la palabra "fizz".
         * - Múltiplos de 5 por la palabra "buzz".         
        */
        public static void Multiplos()
        {            
            for (int x = 1; x <= 100; x++)
            {
                if (x % 3 == 0)               
                    Console.WriteLine("valor: " + x + " multiplo de 3");
                else if (x % 5 == 0)                
                    Console.WriteLine("valor: " + x + " multiplo de 5");                
                else              
                    Console.WriteLine("valor: " + x);
            }
            
        }
    }
}
