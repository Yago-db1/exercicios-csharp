using System.Globalization;
using exercicios;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

OpcoesMenu.ExibirMenuPrincipal();
int opcaoMenu = ValidarEntradaUsuario.LerOpcaoMenuPrincipal();
switch (opcaoMenu)
{
    case 1:
        Exercicio1.CalcularImc();
        break;
    case 2:
        Exercicio2.ClassificarImc();
        break;
    case 3:
        Exercicio3.Calculadora();
        break;
    case 4:
        Exercicio4.NotaAluno();
        break;
    case 5:
        Exercicio5.JogoAdivinhacao();
        break;
    case 6:
        Console.WriteLine("Saindo...");
        break;
}