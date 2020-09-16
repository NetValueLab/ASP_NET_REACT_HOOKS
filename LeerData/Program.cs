using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppVentaCursosContext())
            {
                var cursos = db.Curso.Include(p => p.PrecioPromocion).AsNoTracking();

                foreach(var x in cursos)
                {
                    Console.WriteLine($"Título: {x.Titulo} | Preço: {x.PrecioPromocion.PrecioActual}");
                }
                
                /* var cursos = db.Curso.AsNoTracking();
                foreach(var x in cursos)
                {
                    Console.WriteLine($"Título: {x.Titulo} | Descrição: {x.Descripicion}");
                } */
            }
        }
    }
} 