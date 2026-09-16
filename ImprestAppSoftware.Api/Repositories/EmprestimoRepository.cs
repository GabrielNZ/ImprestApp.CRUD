using Microsoft.EntityFrameworkCore;
public class EmprestimoRepository
{
    private AppDbContext _context;
    
    public EmprestimoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Emprestimo?> GetEmprestimoById(int id)
    {
        return await _context.Emprestimos.FindAsync(id);
    }

    public async Task<List<Emprestimo>> GetAllEmprestimos()
    {
        return await _context.Emprestimos.ToListAsync();
    }

    public async Task AddEmprestimo(Emprestimo emprestimo)
    {
        _context.Emprestimos.Add(emprestimo);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateEmprestimo(Emprestimo emprestimo)
    {
        _context.Emprestimos.Update(emprestimo);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEmprestimo(int id)
    {
        var emprestimo = await _context.Emprestimos.FindAsync(id);
        if (emprestimo != null)
        {
            _context.Emprestimos.Remove(emprestimo);
            await _context.SaveChangesAsync();
        }
    }
}