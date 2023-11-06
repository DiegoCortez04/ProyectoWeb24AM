using Microsoft.EntityFrameworkCore;
using Proyecto24AM.Models.Entities;

namespace Proyecto24AM.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Articulo> Articulos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //INSERT EN LA TABLA ROL
            modelBuilder.Entity<Rol>().HasData(
                new Rol
                {
                    PkRol = 1,
                    Nombre = "Admin"
                },
                new Rol
                {
                    PkRol = 2,
                    Nombre = "Sa"
                });

            //INSERT EN LA TABLA USUARIO
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    PkUsuario = 1,
                    Nombre = "Diego",
                    Apellido = "Cortez",
                    UserName = "DC",
                    Password = "1234",
                    FkRol = 1
                });
        }
    }
}
