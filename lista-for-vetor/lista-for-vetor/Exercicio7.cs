using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lista_for_vetor
{
    class Exercicio7
    {
        public Exercicio7()
        {
            string caracter = "", somaConsoantes = "", somaVogais = "", somaCaracterEspecial;
            int somaConsoantess = 0, somaVogaiss = 0, somaCaracteres = 0, somaCaracterEspeciall = 0;
            
            string[] Caracteres = new string[20];

            for (int i = 0; i < Caracteres.Length; i++)
            {
                Console.Write("Caracter: ");
                Caracteres[i] = Console.ReadLine();
            }

            //soma consoantes

            for (int i = 0; i < Caracteres.Length; i++)
            {
                if ((Caracteres[i] == "b") || (Caracteres[i] == "c"))
                {
                    somaConsoantess = somaConsoantess + 1;
                    somaConsoantes = somaConsoantes + Caracteres[i];
                }

                if ((Caracteres[i] == "d") || (Caracteres[i] == "f"))
                {
                    somaConsoantess = somaConsoantess + 1;
                    somaConsoantes = somaConsoantes + Caracteres[i];
                }

                if ((Caracteres[i] == "g") || (Caracteres[i] == "h"))
                {
                    somaConsoantess = somaConsoantess + 1;
                    somaConsoantes = somaConsoantes + Caracteres[i];
                }

                if ((Caracteres[i] == "j") || (Caracteres[i] == "k"))
                {
                    somaConsoantess = somaConsoantess + 1;
                    somaConsoantes = somaConsoantes + Caracteres[i];
                }

                if ((Caracteres[i] == "l") || (Caracteres[i] == "m"))
                {
                    somaConsoantess = somaConsoantess + 1;
                    somaConsoantes = somaConsoantes + Caracteres[i];
                }

                if ((Caracteres[i] == "n") || (Caracteres[i] == "p"))
                {
                    somaConsoantess = somaConsoantess + 1;
                    somaConsoantes = somaConsoantes + Caracteres[i];
                }

                if ((Caracteres[i] == "q") || (Caracteres[i] == "r"))
                {
                    somaConsoantess = somaConsoantess + 1;
                    somaConsoantes = somaConsoantes + Caracteres[i];
                }

                if ((Caracteres[i] == "s") || (Caracteres[i] == "t"))
                {
                    somaConsoantess = somaConsoantess + 1;
                    somaConsoantes = somaConsoantes + Caracteres[i];
                }

                if ((Caracteres[i] == "v") || (Caracteres[i] == "w"))
                {
                    somaConsoantess = somaConsoantess + 1;
                    somaConsoantes = somaConsoantes + Caracteres[i];
                }

                if ((Caracteres[i] == "x") || (Caracteres[i] == "y"))
                {
                    somaConsoantess = somaConsoantess + 1;
                    somaConsoantes = somaConsoantes + Caracteres[i];
                }

                if (Caracteres[i] == "z")
                {
                    somaConsoantess = somaConsoantess + 1;
                    somaConsoantes = somaConsoantes + Caracteres[i];
                }

                //soma vogais

                if ((Caracteres[i] == "a") || (Caracteres[i] == "e"))
                {
                    somaVogaiss = somaVogaiss + 1;
                    somaVogais = somaVogais + Caracteres[i];
                }

                if ((Caracteres[i] == "i") || (Caracteres[i] == "o"))
                {
                    somaVogaiss = somaVogaiss + 1;
                    somaVogais = somaVogais + Caracteres[i];
                }

                if (Caracteres[i] == "u")
                {
                    somaVogaiss = somaVogaiss + 1;
                    somaVogais = somaVogais + Caracteres[i];
                }

                //soma Caracteres Especiais

                else
                {
                    somaCaracterEspeciall =  somaCaracterEspeciall + 1;
                    somaCaracterEspecial = somaCaracterEspecial + Caracteres[i];
                }
                                                                           
            }

          
        }
    }
}
