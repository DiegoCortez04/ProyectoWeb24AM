using Microsoft.EntityFrameworkCore;
using Proyecto24AM.Context;
using Proyecto24AM.Models.Entities;
using Proyecto24AM.Services.IServices;

namespace Proyecto24AM.Services.Service
{
    public class ArticuloServices : IArticuloServices
    {
        //Guion bajo "_" significa que es una variable privada
        private readonly ApplicationDbContext _context; 
        public ArticuloServices(ApplicationDbContext context)
        {
            _context = context;
        }
        //TRAER TODOS LOS ARTICULOS
        public async Task<List<Articulo>> GetArticulos()
        {
            try
            {
                return await _context.Articulos.ToListAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("ERROR:" + ex.Message);
            }
        }
        //TRAER ARTICULOS POR ID
        public async Task<Articulo> GetArticulosById(int id)
        {
            try
            {
                //Articulo art = await _context.Articulos.FindAsync(id);
                Articulo art = await _context.Articulos.FirstOrDefaultAsync(x => x.PkArticulo == id);
                return art;
            }
            catch (Exception ex)
            {

                throw new Exception("ERROR:" + ex.Message);
            }
        }
        //CREAR ARTICULOS
        public async Task<Articulo> CrearArticulo(Articulo art)
        {
            try
            {
                Articulo request = new Articulo()
                {
                    Nombre = art.Nombre,
                    Descripcion = art.Descripcion,
                    Precio = art.Precio,
                };
                var result =  _context.Articulos.AddAsync(request);
                await _context.SaveChangesAsync();

                return request;
            }
            catch (Exception ex)
            {

                throw new Exception("ERROR:" + ex.Message);
            }
        }
    }
}
