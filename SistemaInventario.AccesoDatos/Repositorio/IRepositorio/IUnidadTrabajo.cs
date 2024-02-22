﻿namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable
    {

        IBodegaRepositorio Bodega {  get; }

        ICategoriaRepositorio Categoria { get; }
        IMarcaRepositorio Marca { get; }

        Task Guardar();

    }
}
