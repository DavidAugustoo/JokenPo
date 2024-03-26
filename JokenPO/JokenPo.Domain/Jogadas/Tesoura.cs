using JokenPo.Core;

namespace JokenPo.Domain.Jogadas
{
    public class Tesoura : Jogada
    {
        public override Resultado Competir(Jogada outraJogada)
        {
            if (outraJogada is Papel || outraJogada is Lagarto)
                return Resultado.Vitoria;
            else if (outraJogada is Tesoura)
                return Resultado.Empate;
            else
                return Resultado.Derrota;
        }
    }
}