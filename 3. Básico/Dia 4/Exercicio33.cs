using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_4
{
    public class Exercicio33
    {
        //Crie um método chamado Soma() que receba qualquer quantidade de números inteiros e mostra a soma deles.
        //Escreva um método Main() que demonstra o método Soma() corretamente, quando passado um, três e cinco inteiros ou um array de 10 inteiros.
        public static void Executar()
        {
            Soma(1);
            Soma(1, 2, 3);
            Soma(1, 2, 3, 4, 5);
            int[] vetA = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Soma(vetA);
        }
        public static void Soma(params int[] vetA)
        {
            Console.WriteLine($"A soma dos números é {vetA.Sum()}");
        }
    }
}
