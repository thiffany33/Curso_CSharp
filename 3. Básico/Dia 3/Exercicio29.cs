using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_3
{
    public class Exercicio29
    {
        //Crie um programa console que declare três arrays de inteiros de tamanhos diferentes.
        //Passe cada array para o método que deve mostrar todos os números de cada array e somar todos.
        public static void Executar()
        {
            int[] vetA = new int[2] { 1, 2};
            int[] vetB = new int[3] { 1, 2, 3}; 
            int[] vetC = new int[4] { 1, 2, 3, 4};

            Mostra(vetA, vetB, vetC);

        }
        public static void Mostra(int[] vetA, int[] vetB, int[] vetC)
        {
            int i = 0;

            //Para mostrar os valores:
            for (i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine($"Na posição {i} do Vetor A tem o valor: {vetA[i]}");
            }
            Console.WriteLine("  ");

            for (i = 0; i < vetB.Length; i++)
            {
                Console.WriteLine($"Na posição {i} do Vetor B tem o valor: {vetB[i]}");
            }
            Console.WriteLine("  ");

            for (i = 0; i < vetC.Length; i++)
            {
                Console.WriteLine($"Na posição {i} do Vetor C tem o valor: {vetC[i]}");
            }
            Console.WriteLine("  ");


            //Para fazer a soma dos valores:
            //vetD vai somar as duas primeiras posições de vetA e vetB

            
            for (i =0; i < vetC.Length; i++)
            {
                int cont = 0;

                if ( vetA.Length > i)
                {
                    cont += vetA[i];
                }
                if (vetB.Length > i)
                {
                    cont += vetB[i];
                }
                if (vetC.Length > i)
                {
                    cont += vetC[i];
                }
                Console.WriteLine($"A soma dos vetores A, B e C na posição {i} é : {cont}");

            }

        }
    }
}
