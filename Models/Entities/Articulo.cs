using System.ComponentModel.DataAnnotations;

namespace Proyecto24AM.Models.Entities
{
    public class Articulo
    {
        [Key]
        public int PkArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
