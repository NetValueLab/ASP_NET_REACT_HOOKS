using System;
namespace LeerData
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Titulo { get; set; }
        public string Descripicion { get; set; }
        public DateTime FechaPulicacion { get; set; }
        public Precio PrecioPromocion { get; set; }
    }
}