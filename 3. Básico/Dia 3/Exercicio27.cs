using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_3
{
    public class Exercicio27
    {
        //Crie uma aplicação console que receba um valor e passa para o método que retorna o quadrado do numero e para o método que retorna o cubo do numero.
        //O método Cubo() pode chamar o método Quadrado().
        //Mostre os resultados retornados de cada um dos métodos criados.
        public static void Executar()
        {
            Console.WriteLine("Digite um valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            Cubo(valor);
        }
        public static void Cubo(int valor)
        {
            Console.WriteLine($"O valor ao cubo é: {Math.Pow(valor, 3)}");

            Quadrado(valor);
        }
        public static void Quadrado(int valor)
        {
            Console.WriteLine($"O valor ao quadrado é: {Math.Pow(valor, 2)} ");
        }
    }
}
