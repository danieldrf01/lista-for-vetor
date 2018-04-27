using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lista_for_vetor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.Write("Digite a quantidade de registros que deseja: ");
            int quantidadeDeRegistros = Convert.ToInt32(Console.ReadLine());

            double[] precos = new double[quantidadeDeRegistros];

            for (int i = 0; i < precos.Length; i++)
            {
                Console.Write("\nPreços: " + "R$");
                precos[i] = Convert.ToDouble(Console.ReadLine());
            }

            double somaPrecos = 0; 

            for(int i = 0; i < precos.Length; i++) 
            {
                somaPrecos = precos[i] + somaPrecos;
            }

            
            Console.WriteLine("\nTotal dos preçoes: " + "R$" + somaPrecos);
 
                
        }
    }
}
