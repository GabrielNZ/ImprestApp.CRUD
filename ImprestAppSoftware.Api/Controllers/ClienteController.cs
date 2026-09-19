using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly ClienteService _clienteService;
    public ClienteController(ClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCliente()
    {
        var clientes = _clienteService.GetAll();
        return Ok(clientes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var cliente = _clienteService.GetById(id);
        if (cliente == null) {  
            return null;
        }
        return Ok(cliente);
    }

    [HttpPost]
    public async Task<IActionResult> PostCliente(Cliente cliente)
    {
        var e = _clienteService.Create(cliente);
        return CreatedAtAction(
            nameof(GetCliente),
            new { id = e.Id },
            e
            );
    }  

    [HttpPut("{id}")]
    public async Task<IActionResult> PutCliente(int id, Cliente cliente)
    {
        var e = _clienteService.Update(id, cliente);
        if (e == null)
        {
            return NotFound();
        }
        return Ok(e);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCliente(int id)
    {
        var e = _clienteService.Delete(id);
        if (e == null)
        {
            return NotFound();
        }
        return Ok(e);
    }
}
