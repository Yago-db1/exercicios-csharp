namespace exercicios;

public class CalcularNota
{
    public static decimal CalculaMediaDasNotas(List<decimal> notas)
    {
        decimal media = notas.Average();
        return media;
    }
    public static decimal CalcularMaiorNota(List<decimal> notas)
    {
        decimal maiorNota = notas.Max();
        return maiorNota;
    }
    public static decimal CalcularMenorNota(List<decimal> notas)
    {
        decimal menorNota = notas.Min();
        return menorNota;
    }
}