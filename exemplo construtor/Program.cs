namespace exemplo_construtor;
class Program
{
    static void Main(string[] args)
    {
        //Produto p1 = new Produto();
        //produto p1 = new produto(100);
        Produto p1 = new Produto("ABC",10);

        p1.MostraDados();
    }
}
