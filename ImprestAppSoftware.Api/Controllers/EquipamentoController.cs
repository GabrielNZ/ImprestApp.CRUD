using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/equipamento")]
public class EquipamentoController : ControllerBase 
{
private readonly EquipamentoService _equipamentoService;

    public EquipamentoController(EquipamentoService equipamentoService)
    {
        _equipamentoService = equipamentoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetEquipamento()
    {
        var equipamento = _equipamentoService.GetAll();
        return Ok(equipamento);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var equipamento = _equipamentoService.GetById(id);
        if (equipamento == null) {  
            return null;
        }
        return Ok(equipamento);
    }

    [HttpPost]
    public async Task<IActionResult> PostEquipamento(Equipamento equipamento)
    {
        var e = _equipamentoService.Create(equipamento);
        return CreatedAtAction(
            nameof(GetEquipamento),
            new { id = e.Id },
            e
            );
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutEquipamento(int id, Equipamento equipamento)
    {
        var e = _equipamentoService.Update(id, equipamento);
        if (e == null)
        {
            return NotFound();
        }
        return Ok(e);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEquipamento(int id)
    {
        var e = _equipamentoService.Delete(id);
        if (e == null)
        {
            return NotFound();
        }
        return Ok(e);
    }

}