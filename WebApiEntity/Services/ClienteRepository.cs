using Microsoft.EntityFrameworkCore;
using WebApiEntity.Data;
using WebApiEntity.Models;

namespace WebApiEntity.Services
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _db;

        public ClienteRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<Cliente>> GetClientesAsync()
        {
            try
            {
                return await _db.Clientes.AsNoTracking().ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Cliente> GetClienteByIdAsync(String id)
        {
            if (id == null) return null;
            try
            {
                return await _db.Clientes.FindAsync(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
