namespace exercicios;

public class Exercicio3
{
    public static void Calculadora()
    {
        while (true)
        {
            OpcoesMenu.ExibirMenuCalculadora();
            int opcaoCalculadora = ValidarEntradaUsuario.LerOpcaoMenuCalculadora();
            if (opcaoCalculadora == 5)
            {
                Console.WriteLine("Saindo...");
                return;
            }
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
                    while (numero2 == 0)
                    {
                        Console.Write("Digite um valor diferente de zero: ");
                        numero2 = ValidarEntradaUsuario.LerNumeroCalculadora();
                    }
                    resultado = OperacoesCalculadora.Dividir(numero1, numero2);
                    break;
            }
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}