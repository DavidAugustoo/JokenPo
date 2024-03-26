using JokenPo.Core;

namespace JokenPo.Domain.Jogadas
{
    public class Papel : Jogada
    {
        public override Resultado Competir(Jogada outraJogada)
        {
            if (outraJogada is Pedra)
                return Resultado.Vitoria;
            else if (outraJogada is Papel)
                return Resultado.Empate;
            else
                return Resultado.Derrota;
        }
    }
}