namespace exercicios;

public class Exercicio4
{
    public static void NotaAluno()
    {
        Console.Clear();
        List<decimal> notasAluno = new List<decimal>();
        Console.Write("Quantos alunos tem na turma? ");
        int quantidadeAlunos = ValidarEntradaUsuario.LerQuantidadeDeAlunos();
        for (int i = 1; i <= quantidadeAlunos; i++)
        {
            Console.Write($"Digite a nota do aluno {i}: ");
            decimal notaAluno = ValidarEntradaUsuario.LerNotaAluno();
            notasAluno.Add(notaAluno);
        }
        Console.Clear();
        Console.WriteLine("=== RELATÓRIO DA TURMA ===");
        Console.WriteLine($"Média da turma: {CalcularNota.CalculaMediaDasNotas(notasAluno):F2}");
        Console.WriteLine($"Aprovados: {ClassificadorAlunos.AlunosAprovados(notasAluno)} aluno(s)");
        Console.WriteLine($"Recuperação: {ClassificadorAlunos.AlunosEmRecuperacao(notasAluno)} aluno(s)");
        Console.WriteLine($"Reprovados: {ClassificadorAlunos.AlunosReprovados(notasAluno)} aluno(s)");
        Console.WriteLine($"Maior nota: {CalcularNota.CalcularMaiorNota(notasAluno):F2}");
        Console.WriteLine($"Menor nota: {CalcularNota.CalcularMenorNota(notasAluno):F2}");
    }
}

