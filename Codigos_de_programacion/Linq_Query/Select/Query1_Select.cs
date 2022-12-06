using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels.Models;


namespace Codigos_de_programacion.Linq_Query.Select
{
    public class Query1_Select
    {
       
        public static void ConsultarEmpleados()
        {
            using(var context = new AdventureWorksDW2019Context())
            {
                var listaEmpleados = (from e in context.DimEmployees
                                      select e
                                    ).ToList();
                Console.WriteLine("\nCONSULTA UTILIZANDO LINQ\n");

                foreach (var item in listaEmpleados)
                {
                    Console.WriteLine(
                        $"{" NOMBRE: "+item.FirstName}"+" "+
                        $"{" APELLIDO: " + item.LastName}");
                }

            }
        }
    }
}
