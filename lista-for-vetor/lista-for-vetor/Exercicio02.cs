﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lista_for_vetor
{
    class Exercicio02
    {
        public Exercicio02()
        {
            int[] idade = new int[7];

            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("Digite a idade: ");
                idade[i] = Convert.ToInt32(Console.ReadLine());
                             
            }

            Console.Clear();

            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("idade: " + idade[i]);
            }


        }

    }
}
