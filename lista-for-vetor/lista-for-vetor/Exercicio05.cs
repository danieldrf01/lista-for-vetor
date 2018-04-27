using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lista_for_vetor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.Write("Quantidade de jogos que deseja cadastrar: ");
            int quantidadeDeRegistros = Convert.ToInt32(Console.ReadLine());

            string[] nomeJogos = new string[quantidadeDeRegistros];
            int[] quantidadeDeJogos = new int[quantidadeDeRegistros];

            for (int i = 0; i < nomeJogos.Length; i++)
            {
                Console.Write("Nome do jogo: ");
                nomeJogos[i] = Console.ReadLine();
                Console.Write("Quantidade do jogo: ");
                quantidadeDeJogos[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            for (int i = 0; i < nomeJogos.Length; i++)
            {
                Console.WriteLine(nomeJogos[i] + " tem " + quantidadeDeJogos[i] + " unidades");
            }



        }
    }
}
