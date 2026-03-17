namespace exercicios;

public class Exercicio3
{
    public static void Calculadora()
    {
        OpcoesMenu.ExibirMenuCalculadora();
        int opcaoCalculadora = ValidarEntradaUsuario.LerOpcaoMenuCalculadora();
        while (opcaoCalculadora !=5)
        {
            Console.Write("Digite o primeiro número: ");
            decimal numero1 = ValidarEntradaUsuario.LerNumeroCalculadora();
            Console.Write("Digite o segundo número: ");
            decimal numero2 = ValidarEntradaUsuario.LerNumeroCalculadora();
            decimal resultado = 0;
            switch (opcaoCalculadora)
            {
                case 1:
                    resultado = OperacoesCalculadora.Somar(numero1, numero2);
                    break;
                case 2:
                    resultado = OperacoesCalculadora.Subtrair(numero1, numero2);
                    break;
                case 3:
                    resultado = OperacoesCalculadora.Multiplicar(numero1, numero2);
                    break;
                case 4:
                    resultado = OperacoesCalculadora.Dividir(numero1, numero2);
                    break;
            }
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            OpcoesMenu.ExibirMenuCalculadora();
            opcaoCalculadora = ValidarEntradaUsuario.LerOpcaoMenuCalculadora();
        }
    }
}