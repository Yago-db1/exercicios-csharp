namespace exercicios;

public class ClassificadorAlunos
{
    public static int AlunosAprovados(List<decimal> notas)
    {
        int aprovados = 0;
        foreach (var nota in notas)
        {
            if (nota >= 7)
                aprovados++;
        }
        return aprovados;
    }
    public static int AlunosEmRecuperacao(List<decimal> notas)
    {
        int recuperacao = 0;
        foreach (var nota in notas)
        {
            if (nota >= 5 && nota < 7)
                recuperacao++;
        }
        return recuperacao;
    }
    public static int AlunosReprovados(List<decimal> notas)
    {
        int reprovados = 0;
        foreach (var nota in notas)
        {
            if (nota < 5)
                reprovados++;
        }
        return reprovados;
    }
}
