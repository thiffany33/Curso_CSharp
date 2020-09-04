using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._1._Lógica
{
    public class Exercicio5
    {
        public static void Executar()
        {
            int[] vet = new int[8];
            PreencherVetor(vet);
            LerVetor(vet);
        }
        private static void PreencherVetor(int[] vet)
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Digite o valor do vetor na posição {i}");

                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        private static void LerVetor(int[] vet)
        {
            Console.WriteLine("Digite o número para verificar se está no vetor: ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < 8; i++)
            {
                if (x == vet[i])
                {
                    Console.WriteLine($"esse número está localizado na posição: {i}");
                }
            }
        }
    }
}
