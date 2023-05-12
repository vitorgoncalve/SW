public class ContratoPessoaJuridica:Contrato
{
    private string cnpj;
    private string inscricaoEstadual;

    public ContratoPessoaJuridica(string descricao, double valor, string cnpj, string inscricaoEstadual)
        : base(descricao, valor)
    {
        this.cnpj = cnpj;
        this.inscricaoEstadual = inscricaoEstadual;
    }

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine("CNPJ: " + cnpj);
        Console.WriteLine("Inscrição Estadual: " + inscricaoEstadual);
    }
}