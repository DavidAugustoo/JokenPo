using JokenPo.Core;

namespace JokenPo.Domain.Jogadas
{
    public class Lagarto : Jogada
    {
        public override Resultado Competir(Jogada outraJogada)
        {
            if (outraJogada is Papel || outraJogada is Spock)
                return Resultado.Vitoria;
            else if (outraJogada is Lagarto)
                return Resultado.Empate;
            else
                return Resultado.Derrota;
        }
    }
}