using exercicios;

class JogarAdivinhacao
{
    public static void ExecutarPartida(int tentativas, int limiteMax)
    {
        int tentativasUsuario = 1;
        var numeroSecreto = NumeroRandomico.GerarNumeroSecreto(limiteMax);
        Console.WriteLine($"Pensei em um número entre 1 e {limiteMax}. Tente adivinhar!: ");
        while (tentativasUsuario <= tentativas)
        {
            Console.WriteLine($"Tentativa {tentativasUsuario} de {tentativas} ");
            Console.Write($"Seu chute: ");
            int chute = ValidarEntradaUsuario.LerChuteUsuario(limiteMax);
            if (chute == numeroSecreto)
            {
                Console.WriteLine($"Parabéns! Você acertou em {tentativasUsuario} tentativas!");
                return;
            }
            if (chute < numeroSecreto)
                Console.WriteLine($"O número é MAIOR que {chute}: ");
            if (chute > numeroSecreto)
                Console.WriteLine($"O número é MENOR que {chute}: ");
            tentativasUsuario++;
        }
        Console.WriteLine($"\nVocê Perdeu! O número era {numeroSecreto}");
    }
}