public interface IEmprestimoService
{
    Task<List<Emprestimo>> GetAll();
    Task<Emprestimo?> GetById(int id);
    Task<Emprestimo> Create(Emprestimo emprestimo);
    Task Update(int id, Emprestimo emprestimo);
    Task Delete(int id);
}