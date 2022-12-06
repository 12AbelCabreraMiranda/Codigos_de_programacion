using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigos_de_programacion.Expresiones_Lambda.Select
{
    public class Query1_Select
    {
        public static void ConsultarEmpleados()
        {
            using (var context = new AdventureWorksDW2019Context())
            {
                var listaEmpleados = context.DimEmployees.ToList();

                Console.WriteLine("\n CONSULTA UTILIZANDO EXPRESIONES LAMBDA\n");

                foreach (var item in listaEmpleados)
                {
                    Console.WriteLine(                        
                        $"{" NOMBRE: " + item.FirstName}" + " " +
                        $"{" APELLIDO: " + item.LastName}");
                }

            }
        }
    }
}
