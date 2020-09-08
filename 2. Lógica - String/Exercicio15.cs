using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio15
    {
        //Crie um programa console que solicite uma frase e conte a quantidade de palavras existem nela.
        public static void Executar()
        {
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();

            int cont = 1; 

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    cont++; 
                }
            }
            Console.WriteLine(cont);
        }
    }
}
