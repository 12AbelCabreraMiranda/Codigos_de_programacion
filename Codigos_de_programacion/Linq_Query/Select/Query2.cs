using DataModels.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigos_de_programacion.Linq_Query.Select
{
    public class Query2
    {
        public static void ConsultarEmpleados()
        {
            using var context = new AdventureWorksDW2019Context();
            var listaEmpleados = (from e in context.DimEmployees
                                  where e.Gender.Equals("F")
                                  select new
                                  {
                                      id = e.EmployeeKey,
                                      Nombre = e.FirstName,
                                      Apellido = e.LastName,
                                      Genero = e.Gender,
                                      TotalVenta = (from v in context.FactResellerSales
                                                    where e.EmployeeKey== v.EmployeeKey
                                                    select  v.SalesAmount).Sum(),

                                      CantidadVenta= (from c in context.FactResellerSales
                                                      where e.EmployeeKey == c.EmployeeKey
                                                      select c.SalesAmount).Count()
                                  }).ToList();


            Console.WriteLine("\nCONSULTA UTILIZANDO LINQ\n");

            foreach (var item in listaEmpleados)
            {
                Console.WriteLine(
                    " NOMBRE: " + item.Nombre + " " +item.Apellido+" GENERO: "+item.Genero+
                    " TOTAL VENTA: Q." + item.TotalVenta+ 
                    " CANTIDAD VENTA: " + item.CantidadVenta);
            }

            Console.WriteLine("\nCANTIDAD DE REGISTROS: "+listaEmpleados.Count());
        }
    }
}
