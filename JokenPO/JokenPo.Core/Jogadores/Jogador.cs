
using JokenPo.Domain;

namespace JokenPo.Core.Jogadores
{
    public class Jogador
    {
        public Jogada Jogada { get; private set; }

        public void EscolherJogada(Jogada jogada)
        {
            Jogada = jogada;
        }
    }
}