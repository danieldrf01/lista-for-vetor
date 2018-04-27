using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lista_for_vetor
{
    class Exercicio06
    {
        public Exercicio06()
        {
            int[] numero = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                // Criar um objeto aleatório
                // Random rnd = new Random ();
                // Criar um objeto aleatório com uma semente com um grau de pseudoaleatória

                Random rnd = new Random(DateTime.Now.Millisecond);

                // Gerando um número aleatório qualquer
                Console.WriteLine(rnd.Next(0,100).ToString());


                // Aguarda até que uma tecla seja pressionada
                Console.ReadKey();
            }
                
            for(int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Todos os números armazedos: " + );
            }
              
        }
    }
}
