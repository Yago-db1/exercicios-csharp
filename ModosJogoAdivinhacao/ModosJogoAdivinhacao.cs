namespace exercicios;

public class ModosJogoAdivinhacao
{
    public static void IniciarModoFacil()
    {
        Console.Clear();
        Console.WriteLine("Modo Fácil");
        JogarAdivinhacao.ExecutarPartida(10, 10);
    }
    public static void IniciarModoMedio()
    {
        Console.Clear();
        Console.WriteLine("Modo Médio");
        JogarAdivinhacao.ExecutarPartida(7, 50);
    }
    public static void IniciarModoDificil()
    {
        Console.Clear();
        Console.WriteLine("Modo Dificil");
        JogarAdivinhacao.ExecutarPartida(5, 100);
    }
}