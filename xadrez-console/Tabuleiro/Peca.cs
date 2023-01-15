using Tabuleiro.Enums;

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QuantidadeMovimentos = 0;
            Tabuleiro = tabuleiro;
        }   
    }
}
