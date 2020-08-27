using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Exercicio3
    {
        public static void Executar()
        {
            Triangulo();
        }
        //Faça um sketch que receba dois números, efetue a soma e mostre o resultado no Serial Monitor.
        public static void Soma()
        {
            Console.WriteLine("Digite o valor de dois número: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;

            Console.WriteLine($"A soma dos dos números {a} e {b} é: {c}");
        }
        //Faça um console que calcule a área de um triângulo retângulo, dados os valores de sua base e altura e mostre o resultado. 
        public static void Triangulo()
        {
            Console.WriteLine("Qual o valor da base? ");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o valor da altura? ");
            int alt = Convert.ToInt32(Console.ReadLine());

            Math.Pow(bas, 2);
            Math.Pow(alt, 2);

            double resultado = Math.Sqrt(bas + alt);

            Console.WriteLine(resultado);

        }
        //Faça um sketch que calcule a média aritmética entre três valores informados. Mostre a média no Serial Monitor.
        public static void Media()
        {
            Console.WriteLine("Digite o valor de três número: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int d = ((a + b + c) / 3);

            Console.WriteLine($"A média entre os números {a}, {b} e {c} é: {d}");
        }
    }
}
