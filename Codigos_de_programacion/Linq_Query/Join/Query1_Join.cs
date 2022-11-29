using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigos_de_programacion.Linq_Query.Join
{
    public class Query1_Join
    {
        public static void ObtenerEmpleadosYsusVentas()
        {
            using var context = new AdventureWorksDW2019Context();

            var listaEmpleados = (from e in context.DimEmployees
                                  join s in context.FactResellerSales on e.EmployeeKey equals s.EmployeeKey                                  
                                  orderby e.EmployeeKey
                                  select new
                                  {
                                      id = e.EmployeeKey,
                                      Nombre =  e.FirstName,
                                      Apellido = e.LastName,
                                      Genero = e.Gender,
                                      TotalVenta = s.SalesAmount
                                  }).ToList();

            Console.WriteLine("\nCONSULTA UTILIZANDO LINQ\n");

            foreach (var item in listaEmpleados)
            {
                Console.WriteLine(
                    " NOMBRE: " + item.Nombre + " " + item.Apellido + " GENERO: " + item.Genero +
                    " TOTAL VENTA: Q." + item.TotalVenta);
            }

            Console.WriteLine("\nCANTIDAD DE REGISTROS: " + listaEmpleados.Count());

        }
    }
}
