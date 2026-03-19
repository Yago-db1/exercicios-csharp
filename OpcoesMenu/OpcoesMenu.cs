namespace exercicios;

public class OpcoesMenu
{
    public static void ExibirMenuCalculadora()
    {
        Console.Clear();
        Console.WriteLine("=== CALCULADORA ===");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");
        Console.Write("Escolha uma opção: ");
    }
    public static void ExibirMenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("=== MENU ===");
        Console.WriteLine("1 - Calculadora de IMC (Índice de Massa Corporal)");
        Console.WriteLine("2 - Classificação de IMC");
        Console.WriteLine("3 - Calculadora");
        Console.WriteLine("4 - Análise de Notas de Alunos");
        Console.WriteLine("5 - Jogo de Adivinhação");
        Console.WriteLine("6 - Para sair");
        Console.Write("Digite uma opção: ");
    }
    public static void ExibirMenuJogoAdivinhacao()
    {
        Console.WriteLine("=== JOGO DE ADIVINHAÇÃO ===");
        Console.WriteLine("Escolha o nível de dificuldade:");
        Console.WriteLine("1 - Fácil (1 a 10) - 10 tentativas");
        Console.WriteLine("2 - Médio (1 a 50) - 7 tentativas");
        Console.WriteLine("3 - Díficil (1 a 100) - 5 tentativas");
        Console.Write("Opção: ");
    }
}
