using Microsoft.EntityFrameworkCore;
public class EquipamentoRepository
{
    private AppDbContext _context;
    
    public EquipamentoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Equipamento?> GetEquipamentoById(int id)
    {
        return await _context.Equipamentos.FindAsync(id);
    }

    public async Task<List<Equipamento>> GetAllEquipamentos()
    {
        return await _context.Equipamentos.ToListAsync();
    }

    public async Task AddEquipamento(Equipamento equipamento)
    {
        _context.Equipamentos.Add(equipamento);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateEquipamento(Equipamento equipamento)
    {
        _context.Equipamentos.Update(equipamento);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEquipamento(int id)
    {
        var equipamento = await _context.Equipamentos.FindAsync(id);
        if (equipamento != null)
        {
            _context.Equipamentos.Remove(equipamento);
            await _context.SaveChangesAsync();
        }
    }
}