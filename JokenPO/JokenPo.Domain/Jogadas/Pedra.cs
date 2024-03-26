
using JokenPo.Core;

namespace JokenPo.Domain.Jogadas
{
    public class Pedra : Jogada
    {
        public override Resultado Competir(Jogada outraJogada)
        {
            if (outraJogada is Tesoura)
                return Resultado.Vitoria;
            else if (outraJogada is Pedra)
                return Resultado.Empate;
            else
                return Resultado.Derrota;
        }
    }
}