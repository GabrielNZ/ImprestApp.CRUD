public interface IClienteService
{
    Task<List<Cliente>> GetAll();
    Task<Cliente> GetById(int id);
    Task<Cliente> Create(Cliente cliente);
    Task Update(int id, Cliente cliente);
    Task Delete(int id);
}