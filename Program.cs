using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
Console.Clear();
Console.WriteLine("=== MENU ===");
Console.WriteLine("1 - Calculadora de IMC (Índice de Massa Corporal)");
Console.WriteLine("2 - Para sair");
Console.Write("Digite uma opção: ");
int opcaoMenu = ValidarEntradaUsuario();
switch (opcaoMenu)
{
    case 1:
        exercicios.Exercicio1.Executar();
        break;
    case 2:
        Console.WriteLine("Saindo...");
        return;
}
int ValidarEntradaUsuario()
{
    int opcao;
    while (true)
    {
        string entradaUsuario = Console.ReadLine()!;

        if (int.TryParse(entradaUsuario, out opcao) && opcao >= 1 && opcao <= 2)
        {
            return opcao;
        }

        Console.Write("Digite uma opção válida (1 ou 2): ");
    }
}