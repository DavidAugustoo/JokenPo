
using JokenPo.Core;

namespace JokenPo.Domain.Jogadas
{
    public class Pedra : Jogada
    {
        public override Resultado Competir(Jogada outraJogada)
        {
            if (outraJogada is Tesoura || outraJogada is Lagarto)
                return Resultado.Vitoria;
            else if (outraJogada is Pedra)
                return Resultado.Empate;
            else
                return Resultado.Derrota;
        }
    }
}