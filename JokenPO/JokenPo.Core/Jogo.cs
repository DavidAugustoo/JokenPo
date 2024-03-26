
using JokenPo.Core.Jogadores;
using JokenPo.Domain.Jogadas;

namespace JokenPo.Core
{
    public class Jogo
    {
        public void IniciarJogo()
        {
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            jogador1.EscolherJogada(new Papel());
            jogador2.EscolherJogada(new Tesoura());

            Resultado resultado = JogoController.VerificarVencedor(jogador1.Jogada, jogador2.Jogada);
            Console.WriteLine(resultado == Resultado.Vitoria ? "O jogador 1 venceu!" : resultado == Resultado.Derrota ? "O jogador 2 venceu!" : "O jogo terminou em empate.");

        }
    }
}