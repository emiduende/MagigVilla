using MagicVilla_API.Modelos;

namespace MagicVilla_API.Reporsitorio.IRepositorio
{
    public interface INumeroVillaRepositorio :IRepositorio<NumeroVilla>
    {
        Task<NumeroVilla> Actualizar(NumeroVilla entidad);
    }
}
