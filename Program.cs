// importação para utilização de ponto em vez de vírgula.
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

// Varíavel para controlar se o jogo vai continuar. (Continua enquanto o usuário digitar "S")
string opcao = "S";

while (opcao == "S")
{
    Console.Clear();

    Console.WriteLine("=== JOGO DE ADIVINHAÇÃO === ");
    Console.WriteLine("Escolha o nível de dificuldade: ");
    Console.WriteLine("1 - Fácil (1 a 10) - 10 tentativas");
    Console.WriteLine("2 - Médio (1 a 50) - 7 tentativas");
    Console.WriteLine("3 - Difícil (1 a 100) - 5 tentativas");
    Console.Write("Opção: ");
    string opcaoMenuJogo = Console.ReadLine()!;
    int opcaoMenu;

    // Validação para entrada do usuário ser entre 1 e 3. loop fica até o usuário digitar um número válido.
    while (!int.TryParse(opcaoMenuJogo, out opcaoMenu) || opcaoMenu < 1 || opcaoMenu > 3)
    {
        Console.Write("Digite uma opção válida (1-3): ");
        opcaoMenuJogo = Console.ReadLine()!;

    }

    // Switch para ir para cada modo com o parametro passado do usuário
    switch (opcaoMenu)
    {
        case 1:
            ModoFacil();
            break;

        case 2:
            ModoMedio();
            break;

        case 3:
            ModoDificil();
            break;

        default:
            Console.Clear();
            Console.WriteLine("Digite uma opção válida");
            break;
    }

}

void ModoFacil()
{
    JogoAdivinhacao(10, 10);
}

void ModoMedio()
{
    JogoAdivinhacao(7, 50);
}

void ModoDificil()
{
    JogoAdivinhacao(5, 100);
}

// Função principal do jogo. Recebe a quantidade de tentativas e o limite máximo do número aleatório.
// O jogador tem que tentar descobrir o número dentre as tentativas disponíveis.
void JogoAdivinhacao(int tentativas, int limiteMax)
{
    Console.Clear();
    int tentativasJogo = 1;

    //Gera um número aleatório entre 1 e o limite máximo.
    Random numeroRandomico = new Random();
    int numeroSecreto = numeroRandomico.Next(1, limiteMax + 1);

    // O jogador vai continuar jogando enquanto tiver tentativas disponíveis.
    while (tentativasJogo <= tentativas)
    {
        Console.Write($"Pensei em um número entre 1 e {limiteMax}. Tente adivinhar!: ");
        string chuteUsuario = Console.ReadLine()!;
        int chute;

        // Validação para evitar letras ou numeros menores que 1 e numeros maiores que o limite máximo
        while (!int.TryParse(chuteUsuario, out chute) || chute < 1 || chute > limiteMax)
        {
            Console.WriteLine($"Digite um número válido entre 1 e {limiteMax}");
            chuteUsuario = Console.ReadLine()!;
        }

        // Se o chute for menor que o número secreto,
        // informamos que o número correto é maior
        if (chute < numeroSecreto)
        {
            Console.Clear();
            Console.WriteLine($"Tentativa {tentativasJogo} de {tentativas} ");
            Console.Write($"Seu chute é: {chute}\n");
            Console.WriteLine($"O número é maior que {chute}");
        }

        // Se o chute for maior que o número secreto,
        // informamos que o número correto é menor
        if (chute > numeroSecreto)
        {
            Console.Clear();
            Console.WriteLine($"Tentativa {tentativasJogo} de {tentativas} ");
            Console.Write($"Seu chute é: {chute}\n");
            Console.WriteLine($"O número é menor que {chute}");
        }

        // Caso o jogador acerte o número, mostra-se a mensagem de vitória e encerramos o jogo atual
        if (chute == numeroSecreto)
        {
            Console.WriteLine($"Tentativa {tentativasJogo} de {tentativas} ");
            Console.Write($"Seu chute é: {chute}\n");
            Console.WriteLine($"Parabéns! Você acertou em {tentativasJogo} tentativas!");
            PerguntarJogarNovamente();
            return;
        }

        tentativasJogo++;
    }

    // Pergunta ao jogador se ele quer iniciar uma nova partida.
    // O resultado altera a variável global "opcao",
    // que controla o loop while principal do jogo.
    Console.WriteLine($"Você perdeu! O número era {numeroSecreto}");
    PerguntarJogarNovamente();
}

Console.WriteLine("Obrigado por jogar!");

void PerguntarJogarNovamente()
{
    Console.Write("Deseja jogar novamente? (S/N): ");
    opcao = Console.ReadLine()!.ToUpper();

    // Validação para usuario digitar S ou N
    while (opcao != "S" && opcao != "N")
    {
        Console.Write("Digite apenas S para Sim ou N para Não: ");
        opcao = Console.ReadLine()!.ToUpper();
    }
}