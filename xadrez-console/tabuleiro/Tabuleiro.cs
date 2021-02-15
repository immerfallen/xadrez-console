using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;
        public Tabuleiro (int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
        public Peca Peca1(int linha,int coluna)
        {
            return Pecas[linha, coluna];
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            Pecas[pos.linha, pos.coluna] = p;
            p.Posicao = pos;
        }

    }
}
