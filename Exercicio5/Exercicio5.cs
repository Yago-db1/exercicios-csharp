namespace exercicios;

public class Exercicio5
{
    public static void JogoAdivinhacao()
    {
        string respostaUsuario = "S";
        while (respostaUsuario == "S")
        {
            Console.Clear();
            OpcoesMenu.ExibirMenuJogoAdivinhacao();
            int opcao = ValidarEntradaUsuario.LerOpcaoMenuJogoAdivinhacao();
            switch (opcao)
            {
                case 1:
                    ModosJogoAdivinhacao.IniciarModoFacil();
                    break;
                case 2:
                    ModosJogoAdivinhacao.IniciarModoMedio();
                    break;
                case 3:
                    ModosJogoAdivinhacao.IniciarModoDificil();
                    break;
            }
            Console.Write("Deseja jogar novamente? (S/N): ");
            respostaUsuario = ValidarEntradaUsuario.LerRespostaUsuario();
        }
        Console.WriteLine("Obrigado por jogar!");
    }
}
