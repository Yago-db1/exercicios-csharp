namespace exercicios;

public class CalcularNota
{
    public static decimal CalculaMediaDasNotas(List<decimal> notas) => notas.Average();
    public static decimal CalcularMaiorNota(List<decimal> notas) => notas.Max();
    public static decimal CalcularMenorNota(List<decimal> notas) => notas.Min();
}