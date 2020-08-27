using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Exercicio6
    {
        //Faça uma função, que receba como parâmetro o preço atual de uma mercadoria e o reajuste a ser aplicado e retorne o novo preço da mercadoria com reajuste.
        //Usar parâmetros passados como referencia. 
        //
        //Faça um metodo que contenha uma função que receba dois vetores com 10 posições cada, A e B, e um parâmetro que define o resultado da operação(vetor C). 
        //Cada posição de A e B possui valores entre 0 e 9, interpretados como dois números inteiros.Calcular a subtração de A - B e retornar o resultado no parâmetro C.
        //Apresentar no Monitor Serial após sair da função
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

            Console.WriteLine(Preco(valor1, reajuste1));

            Console.WriteLine(Preco(valor2, reajuste2));
        }
        public static double Preco(double atual, double reajuste)
        {
            double resultado = 0;

            //int ajuste = reajuste1 * 0.01m;

            resultado = atual + reajuste;

            return resultado;
        }
    }
}
