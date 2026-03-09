// importação para utilização de ponto em vez de vírgula.
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

Console.Clear();

// quantidadeAlunos recebe o retorno de LerQuantidadeAlunos()
int quantidadeAlunos = LerQuantidadeAlunos();

// Lista notas recebem as notas de LerNotas (que chama o metodo LerNotaAluno)
List<double> notas = LerNotas(quantidadeAlunos);

GerarRelatorio(notas);

int LerQuantidadeAlunos()
{
    Console.Write("Quantos alunos tem na turma?: ");
    int quantidadeAluno;

    // Verificação para evitar string ou valor menor que zero em quantidade de aluno.
    while (!int.TryParse(Console.ReadLine(), out quantidadeAluno) || quantidadeAluno <= 0) //feio?
    {
        Console.WriteLine("Digite um número inteiro maior que zero.");
        Console.Write("Quantos alunos tem na turma? ");
    }

    return quantidadeAluno;
}

List<double> LerNotas(int quantidade)
{
    List<double> notas = new List<double>();

    for (int i = 1; i <= quantidade; i++)
    {
        notas.Add(LerNotaAluno(i));
    }

    return notas;
}

double LerNotaAluno(int numeroAluno)
{
    Console.Write($"Digite a nota do aluno {numeroAluno}: ");

    double nota;

    while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10) // feio?
    {
        Console.WriteLine("Digite uma nota válida entre 0 e 10.");
        Console.Write($"Digite a nota do aluno {numeroAluno}: ");
    }

    return nota;
}

void GerarRelatorio(List<double> notas)
{
    int aprovados = 0;
    int recuperacao = 0;
    int reprovados = 0;

    foreach (double nota in notas)
    {
        if (nota >= 7)
        {
            aprovados++;
        }

        if (nota >= 5 && nota < 7)
        {
            recuperacao++;
        }

        if (nota < 5)
        {
            reprovados++;
        }
    }

    Console.Clear();
    Console.WriteLine("=== RELATÓRIO DA TURMA ===");
    Console.WriteLine($"Média da turma: {notas.Average():F2}");
    Console.WriteLine($"Aprovados: {aprovados} aluno(s)");
    Console.WriteLine($"Recuperação: {recuperacao} aluno(s)");
    Console.WriteLine($"Reprovados: {reprovados} aluno(s)");
    Console.WriteLine($"Maior nota: {notas.Max():F2}");
    Console.WriteLine($"Menor nota: {notas.Min():F2}");
}
