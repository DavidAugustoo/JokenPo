
using JokenPo.Domain;

namespace JokenPo.Core
{
    public static class JogoController
    {
        public static Resultado VerificarVencedor(Jogada jogada1, Jogada jogada2)
        {
            return jogada1.Competir(jogada2);
        }
    }
}