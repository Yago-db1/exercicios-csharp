// Exercício 2: Classificação de IMC

// importação para utilização de ponto em vez de vírgula.
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

// Entrada do peso do usuário. 
Console.Write("Digite seu peso (kg): ");
string pesoEntrada = Console.ReadLine()!.Replace(" ", ""); // Retira os espaços caso usuario insira
double peso;

// Verificação se o usuário digitar strings
if (!double.TryParse(pesoEntrada, out peso))
{
    Console.WriteLine("Entrada inválida! Digite apenas números");
    return;
}

// Verificação para peso negativo ou zero
if(peso <= 0)
{
    Console.WriteLine("Digite um peso maior que zero");
    return;
}

// Entrada da altura do usuário.
Console.Write("Digite a sua altura (m): ");


string alturaEntrada = Console.ReadLine()!.Replace(" ", ""); // Retira os espaços caso usuario insira
double altura;  

// Verificação se o usuário digitar strings. 
if (!double.TryParse(alturaEntrada, out altura))
{
    Console.WriteLine("Entrada inválida! Digite apenas números");
    return;
}

// Verificação para altura negativo ou zero
if (altura <=0)
{
    Console.WriteLine("Digite uma altura maior que zero");
    return;
}

// Calculo IMC
double imc = peso / (altura*altura);
Console.WriteLine($"Seu IMC é: {imc:F2} ");

string classificacaoIMC;

// Verificações para cada IMC
if (imc < 18.5)
{
    classificacaoIMC = "Abaixo do peso";
}

 else if (imc < 24.9)
{
    classificacaoIMC = "Peso normal";
}

else if (imc < 29.9)
{
    classificacaoIMC = "Sobrepeso";
}

else if (imc < 34.9)
{
    classificacaoIMC = "Obesidade Grau I";
}

else if (imc < 39.9)
{
    classificacaoIMC = "Obesidade Grau II";
}
 
else
{
    classificacaoIMC = "Obesidade Grau III";
}

Console.WriteLine($"Classificação: {classificacaoIMC}");