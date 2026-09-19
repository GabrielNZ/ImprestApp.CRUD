using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/emprestimo")]
public class EmprestimoController : ControllerBase 
{
private readonly EmprestimoService _emprestimoService;

    public EmprestimoController(EmprestimoService emprestimoService)
    {
        _emprestimoService = emprestimoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetEmprestimo()
    {
        var emprestimo = _emprestimoService.GetAll();
        return Ok(emprestimo);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var emprestimo = _emprestimoService.GetById(id);
        if (emprestimo == null) {  
            return null;
        }
        return Ok(emprestimo);
    }

    [HttpPost]
    public async Task<IActionResult> PostEmprestimo(Emprestimo emprestimo)
    {
        var e = _emprestimoService.Create(emprestimo);
        return CreatedAtAction(
            nameof(GetEmprestimo),
            new { id = e.Id },
            e
            );
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutEmprestimo(int id, Emprestimo emprestimo)
    {
        var e = _emprestimoService.Update(id, emprestimo);
        if (e == null)
        {
            return NotFound();
        }
        return Ok(e);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmprestimo(int id)
    {
        var e = _emprestimoService.Delete(id);
        if (e == null)
        {
            return NotFound();
        }
        return Ok(e);
    }

}