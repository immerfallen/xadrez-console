﻿using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.Linhas; i++)
            {
                for (int j=0; j < tab.Colunas; j++)
                {
                    if (tab.Peca1(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca1(i, j) + "  ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
