using exercicio;

namespace exercicios;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
       // Console.ReadKey();

       //criar uma instancia (objeto) a partir de uma Classe
         Exemplo exe01 = new Exemplo();

         exe01.mostramsg();


        exe01.pegaNome("ANDERSON");

     Console.WriteLine( exe01.mensagem());

     Console.WriteLine("o resultado da soma é:" + exe01.somar(10,20));
       
    }
}
