using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Codigos_de_programacion.Expresiones_Lambda.Select
{
    public class Query2_Select
    {
        public static void ObtenerEmpleadosYsusVentas()
        {
            using var context = new AdventureWorksDW2019Context();

            var listaEmpleados = context.DimEmployees
                                        .Select(e => new
                                        {
                                            Id=e.EmployeeKey,
                                            Nombre=e.FirstName,
                                            Apellido=e.LastName,
                                            Genero=e.Gender,
                                            TotalVenta=(context.FactResellerSales
                                                               .Where(s=>s.EmployeeKey==e.EmployeeKey)
                                                               .Select(v=>v.SalesAmount).Sum()
                                                        ),
                                            
                                            CantidadVenta= (context.FactResellerSales
                                                               .Where(s => s.EmployeeKey == e.EmployeeKey)
                                                               .Select(v => v.SalesAmount).Count()
                                                        ),

                                        }).ToList();

            Console.WriteLine("\nCONSULTA UTILIZANDO EXPRESIONES LAMBDA\n");

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
