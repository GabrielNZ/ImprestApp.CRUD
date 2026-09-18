public interface IEquipamentoService
{
    Task<List<Equipamento>> GetAll();
    Task<Equipamento?> GetById(int id);
    Task<Equipamento> Create(Equipamento equipamento);
    Task Update(int id, Equipamento equipamento);
    Task Delete(int id);
}