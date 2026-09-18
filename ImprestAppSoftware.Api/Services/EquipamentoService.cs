public class EquipamentoService: IEquipamentoService
{
    private readonly EquipamentoRepository _equipamentoRepository;
    public EquipamentoService(EquipamentoRepository equipamentoRepository)
    {
        _equipamentoRepository = equipamentoRepository;
    }

    public async Task<List<Equipamento>> GetAll()
    {
        return await _equipamentoRepository.GetAllEquipamentos();
    }
    public async Task<Equipamento?> GetById(int id)
    {
        return await _equipamentoRepository.GetEquipamentoById(id);
    }
    public async Task<Equipamento> Create(Equipamento equipamento)
    {
        await _equipamentoRepository.AddEquipamento(equipamento);
        return equipamento;
    }
    public async Task Update(int id, Equipamento equipamento)
    {
        var equipamentoRecuperado = await _equipamentoRepository.GetEquipamentoById(id);
        if (equipamentoRecuperado == null)
        {
            return;
        }
        equipamentoRecuperado.Nome = equipamento.Nome;
        equipamentoRecuperado.Descricao = equipamento.Descricao;
        await _equipamentoRepository.UpdateEquipamento(equipamentoRecuperado);
    }
    public async Task Delete(int id)
    {
        await _equipamentoRepository.DeleteEquipamento(id);
    }
}