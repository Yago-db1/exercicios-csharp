namespace exercicios;

public class ValidarEntradaUsuario
{
    public static decimal Executar(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            string entradaUsuario = Console.ReadLine()!;
            if (decimal.TryParse(entradaUsuario, out decimal valor) && valor > 0)
            {
                return valor;
            }
            Console.WriteLine("Digite um valor maior que zero");
        }
    }
    public static int ExecutarMenu()
    {
        while (true)
        {
            string entradaUsuario = Console.ReadLine()!;
            if (int.TryParse(entradaUsuario, out int opcao) && opcao >= 1 && opcao <= 2)
            {
                return opcao;
            }
            Console.Write("Digite uma opção válida (1 ou 2): ");
        }
    }
}
