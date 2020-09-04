using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio12
    {
        //Crie um programa console que solicite uma palavra apresente o tamanho de uma string sem usar a função da biblioteca
        public static void Executar()
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            int cont = 0;
            foreach (var letra in palavra)
            {
                cont++;
            }
            Console.WriteLine(cont);
        }
    }
}
