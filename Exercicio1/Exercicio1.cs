namespace exercicios;

public class Exercicio1
{
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo a Calculadora de IMC");
        double peso = LerEntradaUsuario("Digite o seu peso (kg): ");
        double altura = LerEntradaUsuario("Digite a sua altura(m): ");
        double imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é: {imc:F2} ");
        double LerEntradaUsuario(string mensagem)
        {
            double valor;
            while (true)
            {
                Console.Write(mensagem);
                string entradaUsuario = Console.ReadLine()!;
                if (double.TryParse(entradaUsuario, out valor) && valor > 0)
                {
                    return valor;
                }
                Console.WriteLine("Digite um valor maior que zero");
            }
        }
    }
}