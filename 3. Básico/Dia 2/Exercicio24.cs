using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_2
{
    public class Exercicio24
    {
        //Crie um programa console que receba duas variáveis.Faça dois métodos, Soma() e Subtracao(),
        //que façam respectivamente a soma e subtração de duas variáveis, retorne o valor da operação e apresente os valores.
        public static void Executar()
        {
            Console.WriteLine("Digite dois números: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Soma(a,b);
            Subtração(a, b);

        }
        public static void Soma(int a, int b)
        {
            Console.WriteLine(a+b); 

        }
        public static void Subtração(int a, int b)
        {
            Console.WriteLine(a-b);
        }
    }
}
