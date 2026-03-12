using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
Console.Clear();
Console.WriteLine("=== MENU ===");
Console.WriteLine("1 - Calculadora de IMC (Índice de Massa Corporal)");
Console.WriteLine("2 - Para sair");
Console.Write("Digite uma opção: ");
int opcaoMenu = exercicios.ValidarEntradaUsuario.ExecutarMenu();
switch (opcaoMenu)
{
    case 1:
        exercicios.Exercicio1.Executar();
        break;
    case 2:
        Console.WriteLine("Saindo...");
        return;
}