
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto24AM.Models.Entities
{
    public class Usuario
    {
        [Key]
        public int PkUsuerio {get; set;}
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string UserName { get; set;}
        public string Password { get; set;}
        [ForeignKey("Roles")]
        public int FkRol { get; set;}
        public Rol Roles { get; set;}

    }
}
