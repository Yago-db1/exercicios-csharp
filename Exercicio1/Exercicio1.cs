namespace exercicios;

public class Exercicio1
{
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo a Calculadora de IMC");
        decimal peso = exercicios.ValidarEntradaUsuario.Executar("Digite o seu peso (kg): ");
        decimal altura = exercicios.ValidarEntradaUsuario.Executar("Digite a sua altura(m): ");
        decimal imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é: {imc:F2} ");
    }
}