
using Microsoft.EntityFrameworkCore;
public class ClienteRepository
{
    private AppDbContext _context;

    public ClienteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Cliente?> GetClienteById(int id)
    {
        return await _context.Clientes.FindAsync(id);
    }

    public async Task<List<Cliente>> GetAllClientes()
    {
        return await _context.Clientes.ToListAsync();
    }

    public async Task AddCliente(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCliente(Cliente cliente)
    {
        _context.Clientes.Update(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCliente(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente != null)
        {
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }
    }
}