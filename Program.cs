//Exercício 1: Calculadora de IMC (Índice de Massa Corporal)
// importação para utilização de ponto em vez de virgula.
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
// Entrada do peso e altura do usuario. 
double peso = LerEntradaUsuario("Digite o seu peso (kg): ");
double altura = LerEntradaUsuario("Digite a sua altura(m): ");
// Calculo do IMC
double imc = peso / (altura * altura);
Console.WriteLine($"Seu IMC é: {imc:F2} ");
// Método para validar a entrada do usuário
double LerEntradaUsuario(string mensagem)
{
    double valor;
    while (true)
    {
        Console.Write(mensagem);
        string entradaUsuario = Console.ReadLine()!;
        if (double.TryParse(entradaUsuario, out valor) && valor > 0)
        {
            return valor;
        }
        Console.WriteLine("Digite um valor maior que zero");
    }
}