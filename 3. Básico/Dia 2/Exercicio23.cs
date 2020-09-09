using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_2
{
    public class Exercicio23
    {
        //Escreva um programa contendo um array com cinco inteiros. Atribua valores inteiros. Liste do primeiro para o último, depois do último para o primeiro
        public static void Executar()
        {
            int[] vetA = new int[5];

            vetA[0] = 1;
            vetA[1] = 2;
            vetA[2] = 3;
            vetA[3] = 4;
            vetA[4] = 5;


            Console.WriteLine("Ordem Iversa:");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(vetA[i]);
            }

            Console.WriteLine("  ");
            Console.WriteLine("  ");

            Console.WriteLine("Ordem não inversa:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vetA[i]);
            }

        }
    }
}
