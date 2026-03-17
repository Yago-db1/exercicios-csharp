namespace exercicios;

public class OperacoesCalculadora
{
    public static decimal Somar(decimal numero1, decimal numero2)
    {
        return numero1 + numero2;
    }
    public static decimal Subtrair(decimal numero1, decimal numero2)
    {
        return numero1 - numero2;
    }
    public static decimal Multiplicar(decimal numero1, decimal numero2)
    {
        return numero1 * numero2;
    }
    public static decimal Dividir(decimal numero1, decimal numero2)
    {
        while(numero2 ==0)
        {
            Console.Write("Digite um valor diferente de zero: ");
            numero2 = ValidarEntradaUsuario.LerNumeroCalculadora();
        }
        return numero1 / numero2;
    }
}
