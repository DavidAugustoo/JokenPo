using JokenPo.Core;

namespace JokenPo.Domain
{
    public abstract class Jogada
    {
        public abstract Resultado Competir(Jogada outraJogada);
    }
}