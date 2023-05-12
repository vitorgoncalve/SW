public class Contrato
{
    protected string descricao;
    protected double valor;

    public Contrato(string descricao, double valor)
    {
        this.descricao = descricao;
        this.valor = valor;
    }

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine("Descrição: " + descricao);
        Console.WriteLine("Valor: " + valor);
    }
}