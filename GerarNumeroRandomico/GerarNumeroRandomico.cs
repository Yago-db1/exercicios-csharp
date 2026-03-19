class NumeroRandomico
{
    public static int GerarNumeroSecreto(int limiteMax)
    {
        Random numeroRandomico = new Random();
        int numeroSecreto = numeroRandomico.Next(1, limiteMax + 1);
        return numeroSecreto;
    }
}