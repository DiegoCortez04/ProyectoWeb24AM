﻿using Proyecto24AM.Models.Entities;

namespace Proyecto24AM.Services.IServices
{
    public interface IArticuloServices
    {
        public Task<List<Articulo>> GetArticulos();
        public Task<Articulo> GetArticulosById(int id);
        public Task<Articulo> CrearArticulo(Articulo art);
        public Task<Articulo> EditarArticulo(int id,Articulo art);
        public Task<Articulo> EliminarArticulo(int id);
    }
}
