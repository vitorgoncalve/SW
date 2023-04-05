namespace conta_bancaria;
class Conta
{
    public string? nomeCliente {get; set;}

    public int numeroConta {get; set;}
    private double saldo {get;  set;}
    public double limite {get; set;}

    public void depositar(double valor){
        this.saldo += valor;
    }
    public void sacar(double valor){
        this.saldo = valor;
    }

    public double ConsultaSaldo(){
        return this.saldo + this.limite;
    }
}