using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._1._Lógica
{
    public class Exercicio4
    {
        public static void Executar()
        {
            arranjo();
        }
        //Faça um sketch que imprima no Monitor Serial
        //1.Os números pares compreendidos entre 1 e 100.
        //2.Os números impares compreendidos entre 0 e 150.
        //2.Faça um sketch que imprima no Monitor Serial o resultado do cálculo fatorial de um
        //número entre 1 e 8. Fatorial de N=N* (N-1)* (N-2)..*1.
        //3.Faça um sketch que imprima no Monitor Serial o cálculo do arranjo combinatório
        //segundo a seguinte equação:
        //a = n! / (n - k)!

        public static void Pares()
        {
            Console.WriteLine("Os números pares entre 2 e 100 são: ");
            int i = 0;
            for (i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Impares()
        {
            Console.WriteLine("Os números impares de 0 até 150 são: ");
            int i = 0;
            for (i = 0; i <= 150; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void fatorial()
        {
            Console.WriteLine("Escolha um número entra 0 e 10: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= num; num--)
            {
                fat *= num;
            }
            Console.WriteLine($"O fatorial do número escolhido é: {fat}");
        }
        public static void arranjo()
        {
            double i, j, resultado;
            double fatN = 1;
            double fatX = 1;
            Console.WriteLine("Digite o valor para N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor para K: ");
            int k = Convert.ToInt32(Console.ReadLine());

            for (i = n; i > 1; i--)
            {
                fatN = i * fatN;
            }
            for (j = (n - k); j > 0; j--)
            {
                fatX = j * fatX;
            }
            resultado = fatN / fatX;

            Console.WriteLine($"O resultado: {resultado}");
        }
    }
}
