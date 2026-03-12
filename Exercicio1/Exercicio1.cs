namespace exercicios;

public class Exercicio1
{
    public static decimal Executar()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo a Calculadora de IMC");
        decimal peso = exercicios.ValidarEntradaUsuario.LerDecimal("Digite o seu peso (kg): ");
        decimal altura = exercicios.ValidarEntradaUsuario.LerDecimal("Digite a sua altura(m): ");
        decimal imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é: {imc:F2} ");
        return imc;
    }
}