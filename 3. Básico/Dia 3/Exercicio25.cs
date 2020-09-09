using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_3
{
    public class Exercicio25
    {
        //Crie um programa console que tem um método para converter polegadas em centímetros, lembrando que 1” equivale a 2,54 cm.
        //Faça os testes fazendo com que o usuário possa fornecer os dados das variáveis.
        public static void Executar()
        {
            Console.WriteLine("Digite quantos o valor das polegadas:");
            double valor = Convert.ToInt32(Console.ReadLine());

            valor = valor * 2.54; 

            Console.WriteLine($"O valor em centimetros é: {valor}");


        }
    }
}
