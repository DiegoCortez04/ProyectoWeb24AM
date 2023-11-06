using System.ComponentModel.DataAnnotations;

namespace Proyecto24AM.Models.Entities
{
    public class Rol
    {
        [Key]
        public int PkRol { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
