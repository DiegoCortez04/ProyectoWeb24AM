using Microsoft.EntityFrameworkCore;
using Proyecto24AM.Models.Entities;

namespace Proyecto24AM.Context
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options){ }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
    }
}
