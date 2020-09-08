using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio13
    {
        //Crie um programa console que solicite uma palavra e adicione espaços entre os caracteres e apresente eles na tela.
        public static void Executar()
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            int i;

            for (i = 0; i > palavra.Length; i++)
            {
                palavra = palavra.Insert(i, "  ");

                i ++;
            }
            Console.WriteLine(palavra);
        }
    }
}
