﻿using SistemaInventario.AccesoDatos.Data;
using SistemaInventario.AccesoDatos.Repositorio.IRepositorio;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {

        private readonly ApplicationDbContext _db;
        public IBodegaRepositorio Bodega {  get; private set; }

        public ICategoriaRepositorio Categoria { get; private set; }

        public IMarcaRepositorio Marca { get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;   
            Bodega = new BodegaRepositorio(_db);
            Categoria = new CategoriaRepositorio(_db);
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task Guardar()
        {
            await _db.SaveChangesAsync();
        }
    }
}
