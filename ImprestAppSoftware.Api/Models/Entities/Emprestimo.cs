public class Emprestimo
{
    public Cliente? Cliente { get; set; }
    public Equipamento? Equipamento { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataPrevisao { get; set; }
    public DateTime DataDevolvida { get; set; }
    public decimal ValorTotal { get; set; }
    public StatusEmprestimo status { get; set; }
}