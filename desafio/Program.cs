namespace exerciciosAlunos;


class program 
{
     static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();

        Console.WriteLine(" nome do aluno: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("O nome é: " + nome);



        Console.WriteLine("primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("A primeira nota é: " + nota1);



        Console.WriteLine("segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("A segunda nota é: " + nota2);


        aluno1.nome = nome;
        aluno1.nota1 = nota1;
        aluno1.nota2 = nota2;

        aluno1.mensagem();
         }
}
