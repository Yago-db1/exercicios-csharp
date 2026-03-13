using System.Globalization;
using exercicios;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

OpcoesMenu.ExibirMenuPrincipal();
int opcaoMenu = exercicios.ValidarEntradaUsuario.LerOpcaoMenuPrincipal();
switch (opcaoMenu)
{
    case 1:
        exercicios.Exercicio1.CalcularImc();
        break;
    case 2:
        exercicios.Exercicio2.ClassificarImc();
        break;
    case 3:
        exercicios.Exercicio3.Calculadora();
        break;
    case 4:
        Console.WriteLine("Saindo...");
        return;
}