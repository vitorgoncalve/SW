namespace exercicio;
class Exemplo 
{
    public string nome="";
    public int idade=0;
    public bool vacinado=false;


    //MÉTODOS
    public void mostramsg (){
        Console.WriteLine("oieeee 2f");
    }

public void pegaNome(string texto){
     Console.WriteLine("oieeee: " + texto);
}

public string mensagem(){
    return "Devolvendo um texto";
}
   
    public int somar(int a, int b){
        return a+b;
    }
        
     }
