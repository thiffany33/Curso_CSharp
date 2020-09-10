using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_4
{
    public class Exercicio31
    {
        //Crie um programa console que declare três variáveis inteiras.
        //Faça um método que receba as variáveis e mostre na tela.
        //Faça um método que receba as variáveis por referencia e inverta as posições das variáveis.
        //Mostre os valores das variáveis novamente.
        public static void Executar()
        {
            int a = 0;
            int b = 1;
            int c = 2;


            Receber(a, b, c);
            Referencia(ref a, ref b, ref c);
        }
        public static void Receber(int a, int b, int c)
        {
            Console.WriteLine("Os valores originais são:");
            Console.WriteLine($"O valor de A é: {a}");
            Console.WriteLine($"O valor de B é: {b}");
            Console.WriteLine($"O valor de C é: {c}");
            Console.WriteLine("   ");
        }
        public static void Referencia(ref int a, ref int b, ref int c)
        {
            int d;

            d = a;
            a = b;
            b = c;
            c = d;

            Console.WriteLine("Os valores invertidos são:");
            Console.WriteLine($"O novo A agora vale: {a}");
            Console.WriteLine($"O novo B agora vale: {b}");
            Console.WriteLine($"O novo C agora vale: {c}");
        }
    }
}