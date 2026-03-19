namespace exercicios;

public class ValidarEntradaUsuario
{
    public static decimal LerDecimal(string mensagem)
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
    public static int LerOpcaoMenuPrincipal()
    {
        while (true)
        {
            string entradaUsuario = Console.ReadLine()!;
            if (int.TryParse(entradaUsuario, out int opcao) && opcao >= 1 && opcao <= 5)
            {
                return opcao;
            }
            Console.Write("Digite uma opção válida (1 a 5): ");
        }
    }
    public static int LerOpcaoMenuCalculadora()
    {
        while (true)
        {
            string entradaUsuario = Console.ReadLine()!;
            if (int.TryParse(entradaUsuario, out int opcao) && opcao >= 1 && opcao <= 5)
            {
                return opcao;
            }
            Console.Write("Digite uma opção válida (1 a 5): ");
        }
    }
    public static decimal LerNumeroCalculadora()
    {
        while (true)
        {
            string entradaUsuario = Console.ReadLine()!;
            if (decimal.TryParse(entradaUsuario, out decimal opcao))
            {
                return opcao;
            }
            Console.Write("Digite um valor númerico: ");
        }
    }
    public static int LerQuantidadeDeAlunos()
    {
        while (true)
        {
            string entradaUsuario = Console.ReadLine()!;
            if (int.TryParse(entradaUsuario, out int opcao) && opcao > 0)
            {
                return opcao;
            }
            Console.Write("Digite um valor númerico inteiro: ");
        }
    }
    public static decimal LerNotaAluno()
    {
        while (true)
        {
            string entradaUsuario = Console.ReadLine()!;
            if (decimal.TryParse(entradaUsuario, out decimal opcao) && opcao >= 0 && opcao <= 10)
            {
                return opcao;
            }
            Console.Write("Digite uma nota entre 0 e 10: ");
        }
    }
    public static int LerOpcaoMenuJogoAdivinhacao()
    {
        while (true)
        {
            string entradaUsuario = Console.ReadLine()!;
            if (int.TryParse(entradaUsuario, out int opcao) && opcao >= 0 && opcao <= 3)
            {
                return opcao;
            }
            Console.Write("Digite uma opção entre 1 e 3");
        }
    }
    public static int LerChuteUsuario(int limiteMax)
    {
        while (true)
        {
            string entradaUsuario = Console.ReadLine()!;
            if (int.TryParse(entradaUsuario, out int opcao) && opcao > 0 && opcao <= limiteMax)
            {
                return opcao;
            }
            Console.Write($"Digite uma opção entre 1 e {limiteMax}:  ");
        }
    }
    public static string LerRespostaUsuario()
    {
        string resposta;
        while (true)
        {
            resposta = Console.ReadLine()!;
            if (resposta == "S" || resposta == "N")
            {
                return resposta;
            }
            Console.WriteLine("Entrada inválida! Digite apenas 'S' para sim ou 'N' para não.");
        }
    }
}