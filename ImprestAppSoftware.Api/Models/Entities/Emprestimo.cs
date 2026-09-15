public class Emprestimo
{
    public Cliente Cliente { get; set; }
    public Equipamento Equipamento { get; set; }
    public Date DataInicio { get; set; }
    public Data DataPrevisao { get; set; }
    public Data DataDevolvida { get; set; }
    public decimal ValorTotal { get; set; }
    public Status status { get; set; }
}