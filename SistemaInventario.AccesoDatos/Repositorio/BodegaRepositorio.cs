using SistemaInventario.AccesoDatos.Data;
using SistemaInventario.AccesoDatos.Repositorio.IRepositorio;
using SistemaInventario.Modelos;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public class BodegaRepositorio : Repositorio<Bodega>, IBodegaRepositorio
    {

        private readonly ApplicationDbContext _db;

        public BodegaRepositorio(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Actualizar(Bodega bodega)
        {
            var BodegaBD = _db.Bodegas.FirstOrDefault(b => b.Id == bodega.Id);
            if (BodegaBD != null) 
            { 
                BodegaBD.Nombre = bodega.Nombre;
                BodegaBD.Descripcion = bodega.Descripcion;
                BodegaBD.Estado = bodega.Estado;
                _db.SaveChanges();
            }
        }

    }
}
