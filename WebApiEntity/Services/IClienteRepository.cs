using WebApiEntity.Models;

namespace WebApiEntity.Services
{
    public interface IClienteRepository
    {
        // Cliente Services
        Task<List<Cliente>> GetClientesAsync(); // GET All Clientes
        Task<Cliente> GetClienteByIdAsync(String id); // GET Single Cliente

    }
}
