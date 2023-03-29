namespace exemplo;
class produto
{
    public string? Nome {get;set;}
    public double preco {get;set;}

    public void mostradados(){
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Preço: " + this.preco);
    }
    public void AlteraPreco(double preco){
        if(preco >= 0){
         this.preco = preco;
        }else{
            Console.WriteLine("VALOR INVÁLIDO");
        }
       
    }
    public void AlteraNome(string nome){
        this.Nome = nome;
    }
}