using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio08
    {
        //Crie um programa console que verifique se uma frase termina com um ponto final, caso ela tenha remova esse ponto.
        public static void Executar()
        {
            Console.WriteLine("Digite uma frase qualquer: ");
            string frase = Console.ReadLine();

            //frase = frase.Replace(".", "");

            frase = frase.TrimEnd('.');

            Console.WriteLine(frase);
        }
    }
}
