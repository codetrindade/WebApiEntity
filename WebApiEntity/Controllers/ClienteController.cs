using Microsoft.AspNetCore.Mvc;
using WebApiEntity.Services;

namespace WebApiEntity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _libraryService;

        public ClienteController(IClienteRepository libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            var Clientes = await _libraryService.GetClientesAsync();

            if (Clientes == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "No Clientes in database");
            }

            return StatusCode(StatusCodes.Status200OK, Clientes);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetCliente(String id)
        {
            var Cliente = await _libraryService.GetClienteByIdAsync(id);

            if (Cliente == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, $"No Cliente found for id: {id}");
            }

            return StatusCode(StatusCodes.Status200OK, Cliente);
        }

    }
}
