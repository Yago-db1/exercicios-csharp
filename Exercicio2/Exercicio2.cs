namespace exercicios;

public class Exercicio2
{
    public static void ClassificarImc()
    {
        var imc = Exercicio1.CalcularImc();
        string classificacaoIMC = imc switch
        {
            < 18.5m => "Abaixo do peso",
            < 24.9m => "Peso normal",
            < 29.9m => "Sobrepeso",
            < 34.9m => "Obesidade Grau I",
            < 39.9m => "Obesidade Grau II",
            _ => "Obesidade Grau III"
        };
        Console.WriteLine($"Classificação: {classificacaoIMC}");
    }
}
