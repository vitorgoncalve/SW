namespace conta_bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio Conta Bancária - ETECMCM");
        Conta conta = new Conta();

        conta.nomeCliente = "Vitor Antonio";

        conta.limite = 1000;

        conta.depositar(300);
        
        conta.sacar(150);    

        double saldo = conta.ConsultaSaldo();

        Console.WriteLine("Seu saldo é de " + saldo);

    }
}
