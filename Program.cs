//Exercício 1: Calculadora de IMC (Índice de Massa Corporal)
// importação para utilização de ponto em vez de virgula.
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

// Entrada do peso do usuário
Console.WriteLine("Digite seu peso (kg): ");
double peso = Convert.ToDouble(Console.ReadLine()!);

//Verificação para peso negativo ou zero
if(peso <= 0)
{
    Console.WriteLine("Digite um peso maior que zero");
    return;
}

// Entrada da altura do usuário
Console.WriteLine("Digite sua altura (m): ");
double altura = double.Parse(Console.ReadLine()!);

// Verificação para alturas negativas ou zero
if(altura <= 0)
{
    Console.WriteLine("Digite uma altura maior que zero");
    return;
}

// Calculo do IMC
double imc = peso / (altura*altura);
Console.WriteLine($"Seu IMC é: {imc:F2} ");
