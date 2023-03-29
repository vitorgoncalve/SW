namespace exemplo;
class Program
{
    static void Main(string[] args)
    {
    produto p1 = new produto();
    //p1.Preco = 20;
    p1.AlteraPreco(15);
    p1.AlteraNome("PARAFUSO");
    p1.mostradados();

    //console.whiteline("gavetas:" + p1.Preco);
    }
}
