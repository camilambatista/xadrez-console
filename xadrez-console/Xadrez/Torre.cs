using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "T ";
        }
    }
}
