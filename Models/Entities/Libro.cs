using System.ComponentModel.DataAnnotations;

namespace Proyecto24AM.Models.Entities
{
    public class Libro
    {
        [Key]
        public int PkLibro { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Decripcion { get; set; }
        [Required]
        public string Images { get; set; }
        [Required]
        public string Activo { get; set; }
    }
}
