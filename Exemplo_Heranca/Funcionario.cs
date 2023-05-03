namespace Exemplo_Heranca;

class Funcionario
{
    public string? Nome {get;set;}

    public virtual double Lucro(){
        return 20000;
    }
}
