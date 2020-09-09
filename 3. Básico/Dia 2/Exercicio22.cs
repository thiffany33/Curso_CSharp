using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_2
{
    public class Exercicio22
    {
        //Escreva um programa que mostre todos os números pares de 2 até 100, inclusive.
        public static void Executar()
        {
            Soma();
        }
        public static void Pares()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
        //Escreva um programa que some os números de 1 até 50.
        public static void Soma()
        {
            int sum = 0;
            for (int i = 0; i <= 50; i++)
            {
               sum = sum + i;
            }
            Console.WriteLine(sum);


        }
    }
}
