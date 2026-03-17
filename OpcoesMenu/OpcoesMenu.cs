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
        Console.WriteLine("4 - Para sair");
        Console.Write("Digite uma opção: ");
    }
}
