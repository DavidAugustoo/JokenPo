using JokenPo.Core;

namespace JokenPo.Domain.Jogadas
{
    public class Spock : Jogada
    {
        public override Resultado Competir(Jogada outraJogada)
        {
            if (outraJogada is Tesoura || outraJogada is Pedra)
                return Resultado.Vitoria;
            else if (outraJogada is Spock)
                return Resultado.Empate;
            else
                return Resultado.Derrota;
        }
    }
}