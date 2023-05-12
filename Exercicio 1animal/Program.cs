namespace exercicio1;
class Program
{
    static void Main(string[] args)
    {
    Homem Thiago = new Homem();
    Cao Pitoco = new Cao();
    Gato Mel = new Gato();

    Console.WriteLine("quando o homem falar:" + Thiago.Fala());
    Console.WriteLine("quando o cachorro latir:" + Pitoco.Fala());
    Console.WriteLine("quando o gato miar:" + Mel.Fala());
    }   
        
}
