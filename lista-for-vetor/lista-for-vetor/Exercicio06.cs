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
            Random rnd = new Random();

            double Soma = 0, SomaPares = 0, SomaPositivos = 0, SomaImpar = 0, SomaNegativo = 0, SomaNeutro = 0;
            double[] Numeros = new double[10];

            // gerador de numero aleatorio

            for (int i = 0; i < Numeros.Length; i++)
            { 
                Numeros[i] = Convert.ToDouble(rnd.Next(-10, 10));

                Soma = Soma + Numeros[i];
            }

            double Media = Soma / Numeros.Length;

            Console.Clear();

            // Mostrando ao usuario os numeros gerados
            for(int i = 0; i < Numeros.Length; i++)
            {
                Console.WriteLine("Numeros armazenados: " + Numeros[i]);
            }

            for (int i = 0; i < Numeros.Length; i++)
            {
                //Soma dos numeros pares

                if(Numeros[i] % 2 == 0)
                {
                    SomaPares = SomaPares + 1; 
                }

                //Soma positivos
                if(Numeros[i] > 0)
                {
                    SomaPositivos = SomaPositivos + 1;
                }

                //Soma impar
                if (Numeros[i] % 2 == 1)
                {
                    SomaImpar = SomaImpar + 1;
                }

                //Soma negativo
                if (Numeros[i] < 0)
                {
                    SomaNegativo = SomaNegativo + 1; 
                }

                // Soma neutro
                if (Numeros[i] == 0)
                {
                    SomaNeutro = SomaNeutro + 1; 
                }
            }
            Console.WriteLine("");
            Console.WriteLine("1- Soma Dos Números: " + Soma);
            Console.WriteLine("2- Media Dos Números: " + Media);
            Console.WriteLine("3- Quantidade De Números Pares: " + SomaPares);
            Console.WriteLine("4- Quantidade Dos Números Positivos: " + SomaPositivos);
            Console.WriteLine("5- Quantidade De Números Ímpares: " + SomaImpar);
            Console.WriteLine("6- Quantidade De Números Negativos: " + SomaNegativo);
            Console.WriteLine("7- Quantidade de Números Neutros: " + SomaNeutro);


            Console.ReadKey();

             
        }
    }
}
