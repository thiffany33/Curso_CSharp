using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._1._Lógica
{
    public class Exercicio6
    {
        //Faça uma função, que receba como parâmetro o preço atual de uma mercadoria e o reajuste a ser aplicado e retorne o novo preço da mercadoria com reajuste.
        //Usar parâmetros passados como referencia. 
        public static void Executar()
        {
            Console.WriteLine("Digite o valor da mercadoria 1");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da mercadoria 2");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a porcentagem de de reajuste gostaria de fazer no produto 1");
            double reajuste1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a porcentagem de de reajuste gostaria de fazer no produto 2");
            double reajuste2 = Convert.ToDouble(Console.ReadLine());

            Preco(valor1, reajuste1);

            Preco(valor2, reajuste2);
        }
        public static void Preco(double atual, double reajuste)
        {
            double resultado;

            double ajuste = (reajuste * (0.01));

            resultado = atual + (ajuste * atual);

            Console.WriteLine(resultado);
        }
        //Faça um metodo que receba dois vetores com 10 posições cada, A e B, e um parâmetro que define o resultado da operação(vetor C). 
        //Cada posição de A e B possui valores entre 0 e 9, interpretados como dois números inteiros.
        //Calcular a subtração de A - B e retornar o resultado no parâmetro C.
        //Apresentar no Monitor Serial após sair da função
        public static void Vetor()
        {
            int[] vetA = new int[10];
            int[] vetB = new int[10];
            int[] vetC = new int[10];

            Leitura(vetA, vetB);
            Subtracao(vetA, vetB, vetC);
        }
        public static void Leitura(int[] vetA, int[] vetB)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o valor que você deseja colocar na posição {i} do Vetor A");
                vetA[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o valor que você deseja colocar na posição {i} do Vetor B");
                vetB[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void Subtracao(int[] vetA, int[] vetB, int[] vetC)
        {
            for (int i = 0; i < 10; i++)
            {
                vetC[i] = vetA[i] - vetB[i];
                Console.WriteLine($"{vetA[i]}, {vetB[i]}, {vetC[i]}");
            }
        }
    }
}
