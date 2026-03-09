// Importação para utilização de ponto em vez de vírgula.
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

int opcao = 0;

// Utilizando while para fazer o menu de opções.
while (opcao != 5)
{
    Console.Clear();
    Console.WriteLine("=== CALCULADORA ===");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");
    Console.Write("Escolha uma opção: ");

    string opcaoEscolhida = Console.ReadLine()!;

    if (!int.TryParse(opcaoEscolhida, out opcao))
    {
        Console.WriteLine("Entrada inválida. Digite uma opção válida!");
        Console.ReadKey();
        continue;

    }

    switch (opcao)
    {
        case 1:
            Somar();
            break;

        case 2:
            Subtrair();
            break;

        case 3:
            Multiplicacao();
            break;

        case 4:
            Divisao();
            break;

        case 5:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Digite uma opção válida");
            Console.ReadKey();
            break;
    }
}

double LerNumero(string mensagem)
{
    Console.Write(mensagem);

    string entrada = Console.ReadLine()!.Replace(" ", "");
    double numero;
    while (!double.TryParse(entrada, out numero))
    {
        Console.WriteLine("Número inválido. Tente novamente.");
        Console.Write(mensagem);
        entrada = Console.ReadLine()!.Replace(" ", "");
    }
    return numero;
}

void Somar()
{
    Console.Clear();

    double numero1 = LerNumero("Digite o primeiro número: ");
    double numero2 = LerNumero("Digite o segundo número: ");
    double resultadoSoma = numero1 + numero2;

    Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultadoSoma}");
    Console.WriteLine("Digite qualquer tecla para finalizar...");
    Console.ReadKey();
    Console.Clear();
}

void Subtrair()
{
    Console.Clear();

    double numero1 = LerNumero("Digite o primeiro número: ");
    double numero2 = LerNumero("Digite o segundo número: ");
    double resultadoSubtracao = numero1 - numero2;

    Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultadoSubtracao}");
    Console.WriteLine("Digite qualquer tecla para finalizar...");
    Console.ReadKey();
    Console.Clear();

}

void Multiplicacao()
{
    Console.Clear();

    double numero1 = LerNumero("Digite o primeiro número: ");
    double numero2 = LerNumero("Digite o segundo número: ");
    double resultadoMultiplicacao = numero1 * numero2;

    Console.WriteLine($"Resultado: {numero1} * {numero2} = {resultadoMultiplicacao}");
    Console.WriteLine("Digite qualquer tecla para finalizar...");
    Console.ReadKey();
    Console.Clear();
}

void Divisao()
{
    Console.Clear();
    double numero1 = LerNumero("Digite o primeiro número: ");
    double numero2 = LerNumero("Digite o segundo número: ");

    while (numero2 == 0)
    {
        Console.WriteLine("O número divisor não pode ser 0");
        numero2 = LerNumero("Digite o segundo número: ");
    }

    double resultadoDivisao = numero1 / numero2;

    Console.WriteLine($"Resultado: {numero1} / {numero2} = {resultadoDivisao}");
    Console.WriteLine("Digite qualquer tecla para finalizar...");
    Console.ReadKey();
    Console.Clear();
}
