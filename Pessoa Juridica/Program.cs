namespace Pessoa_Juridica;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica contratoPessoaFisica = new ContratoPessoaFisica("Contrato Pessoa Física", 1000.0, "123.456.789-00", 30);
        contratoPessoaFisica.ExibirDetalhes();
        Console.WriteLine();

        ContratoPessoaJuridica contratoPessoaJuridica = new ContratoPessoaJuridica("Contrato Pessoa Jurídica", 5000.0, "12.345.678/0001-00", "123456789");
        contratoPessoaJuridica.ExibirDetalhes();
    }
        
    
}

