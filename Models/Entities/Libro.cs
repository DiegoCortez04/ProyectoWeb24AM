using System.ComponentModel.DataAnnotations;

namespace Proyecto24AM.Models.Entities
{
    public class Libro
    {
        [Key]
        public int PkLibro { get; set; }
        public string Titulo { get; set; }
        public string Decripcion { get; set; }
        public string Images { get; set; }
    }
}
