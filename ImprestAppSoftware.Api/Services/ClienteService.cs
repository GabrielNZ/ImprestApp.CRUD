public class ClienteService: IClienteService
{
    private readonly ClienteRepository _clienteRepository;
    public ClienteService(ClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<List<Cliente>> GetAll()
    {
        return await _clienteRepository.GetAllClientes();
    }
    public async Task<Cliente?> GetById(int id)
    {
        return await _clienteRepository.GetClienteById(id);
    }
    public async Task<Cliente> Create(Cliente cliente)
    {
        await _clienteRepository.AddCliente(cliente);
        return cliente;
    }
    public async Task Update(int id, Cliente cliente)
    {
        var clienteRecuperado = await _clienteRepository.GetClienteById(id);
        if (clienteRecuperado == null)
        {
            return;
        }
        clienteRecuperado.Email = cliente.Email;
        clienteRecuperado.Nome = cliente.Nome;
        await _clienteRepository.UpdateCliente(clienteRecuperado);
    }
    public async Task Delete(int id)
    {
        await _clienteRepository.DeleteCliente(id);
    }

}