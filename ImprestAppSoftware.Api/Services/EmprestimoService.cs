public class EmprestimoService: IEmprestimoService
{
    private readonly EmprestimoRepository _emprestimoRepository;
    public EmprestimoService(EmprestimoRepository emprestimoRepository)
    {
        _emprestimoRepository = emprestimoRepository;
    }

    public async Task<List<Emprestimo>> GetAll()
    {
        return await _emprestimoRepository.GetAllEmprestimos();
    }
    public async Task<Emprestimo?> GetById(int id)
    {
        return await _emprestimoRepository.GetEmprestimoById(id);
    }
    public async Task<Emprestimo> Create(Emprestimo emprestimo)
    {
        await _emprestimoRepository.AddEmprestimo(emprestimo);
        return emprestimo;
    }
    public async Task Update(int id, Emprestimo emprestimo)
    {
        var emprestimoRecuperado = await _emprestimoRepository.GetEmprestimoById(id);
        if (emprestimoRecuperado == null)
        {
            return;
        }
        emprestimoRecuperado.DataInicio = emprestimo.DataInicio;
        emprestimoRecuperado.DataDevolvida = emprestimo.DataDevolvida;
        emprestimoRecuperado.Cliente = emprestimo.Cliente;
        emprestimoRecuperado.Equipamento = emprestimo.Equipamento;
        await _emprestimoRepository.UpdateEmprestimo(emprestimoRecuperado);
    }
    public async Task Delete(int id)
    {
        await _emprestimoRepository.DeleteEmprestimo(id);
    }

}