using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
