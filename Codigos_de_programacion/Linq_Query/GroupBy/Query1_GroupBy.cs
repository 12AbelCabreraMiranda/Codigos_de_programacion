using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigos_de_programacion.Linq_Query.GroupBy
{
    public class Query1_GroupBy
    {
        public static void ObtenerEmpleadosYsusVentas()
        {
            using var context = new AdventureWorksDW2019Context();

            var listaEmpleados = (from e in context.DimEmployees
                                  join s in context.FactResellerSales on e.EmployeeKey equals s.EmployeeKey
                                  group s by new { e.EmployeeKey, e.FirstName, e.LastName, e.Gender } into g
                                  orderby g.Key.EmployeeKey
                                  select new
                                  {
                                      id = g.Key.EmployeeKey,
                                      Nombre = g.Key.FirstName,
                                      Apellido = g.Key.LastName,
                                      Genero = g.Key.Gender,
                                      TotalVenta = g.Sum(s => s.SalesAmount),
                                      CantidadVenta = g.Count(),
                                  }).ToList();

            Console.WriteLine("\nCONSULTA UTILIZANDO LINQ\n");

            foreach (var item in listaEmpleados)
            {
                Console.WriteLine(
                    " NOMBRE: " + item.Nombre + " " + item.Apellido + " GENERO: " + item.Genero +
                    " TOTAL VENTA: Q." + item.TotalVenta +
                    " CANTIDAD VENTA: " + item.CantidadVenta);
            }

            Console.WriteLine("\nCANTIDAD DE REGISTROS: " + listaEmpleados.Count());

        }
    }
}
