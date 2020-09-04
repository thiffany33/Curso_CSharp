using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio8
    {
        //Crie um programa console que verifique se uma frase termina com um ponto final, caso ela tenha remova esse ponto.
        public static void Executar()
        {
            Console.WriteLine("Digite uma frase qualquer: ");
            string frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == '.')
                {
                    frase.LastIndexOf('.');
                }
            }
            Console.WriteLine(frase);
        }
    }
}
