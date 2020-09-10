using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_3
{
    public class Exercicio30
    {
        //Crie uma aplicação console que tenha um método que receba 10 números inteiros e guarde-os em um array.
        //Passe o array para o método que determina e exibe o maior e o maior dos 10 números.

        public static void Executar()
        {
            int[] vetA = new int[10];

            Receber(vetA);
            Mostar(vetA);
        }
        public static void Receber(int[] vetA)
        {
            for (int i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine($"Digite o valor que deseja na posição {i}");
                vetA[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void Mostar(int[] vetA)
        {
            var maior = vetA[0];
            for (int i = 0; i < vetA.Length; i++)
            {
                if (maior <= vetA[i])
                {
                    maior = vetA[i];
                }
            }
            var menor = vetA[0];
            for (int i = 0; i < vetA.Length; i++)
            {
                if (menor >= vetA[i])
                {
                    menor = vetA[i];
                }
            }
            Console.WriteLine($"O maior número é {maior}");
            Console.WriteLine($"O menor número é {menor}");
        }
    }
}
