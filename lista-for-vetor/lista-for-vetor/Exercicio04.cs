using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lista_for_vetor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            Console.Write("Digite a quantidade de camisas: ");
            int quantidadeDeCamisas = Convert.ToInt32(Console.ReadLine());

            string[] tamanhos = new string[quantidadeDeCamisas];

            int tamanhoP = 0;
            int tamanhoPP = 0;
            int tamanhoM = 0;
            int tamanhoG = 0;
            int tamanhoGG = 0;
            int tamanhoXG = 0;
            int tamanhoXGG = 0;

            for (int i = 0; i < tamanhos.Length; i++)
            {
                Console.Write("\nDigite o tamanho da camisa: ");
                tamanhos[i] = Console.ReadLine();

            }

            for (int i = 0; i < tamanhos.Length; i++)
            {
                if (tamanhos[i] == "pp")
                {
                    tamanhoPP = tamanhoPP + 1;
                }

                else if (tamanhos[i] == "p")
                {
                    tamanhoP = tamanhoP + 1;
                }

                else if (tamanhos[i] == "m")
                {
                    tamanhoM = tamanhoM + 1;
                }

                else if (tamanhos[i] == "g")
                {
                    tamanhoG = tamanhoG + 1;
                }

                else if (tamanhos[i] == "gg")
                {
                    tamanhoGG = tamanhoGG + 1;
                }

                else if (tamanhos[i] == "xg")
                {
                    tamanhoXG = tamanhoXG + 1;
                }

                else if (tamanhos[i] == "xgg")
                {
                    tamanhoXGG = tamanhoXGG + 1;
                }

                    Console.WriteLine("Tamanhos: " + tamanhos[i]);

                    Console.Clear();

                    Console.WriteLine("Quantidade de camisas PP: " + tamanhoPP);
                    Console.WriteLine("Quantidade de camisas P: " + tamanhoP);
                    Console.WriteLine("Quantidade de camisas M: " + tamanhoM);
                    Console.WriteLine("Quantidade de camisas G: " + tamanhoG);
                    Console.WriteLine("Quantidade de camisas GG: " + tamanhoGG);
                    Console.WriteLine("Quantidade de camisas XG: " + tamanhoXG);
                    Console.WriteLine("Quantidade de camisas XGG: " + tamanhoXGG);
                }



            
        }
    }
}
