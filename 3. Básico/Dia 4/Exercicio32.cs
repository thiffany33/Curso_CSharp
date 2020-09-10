using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_4
{
    public class Exercicio32
    {
        //Crie um programa console que declare um array de oito posições.
        //Faça um método para preencher os valores das posições.
        //Faça um método que aceite dois parâmetros out que retornem respectivamente a soma e a média dos valores do array.
        public static void Executar()
        {
            int[] vetA = new int[8];

            Preencher(ref vetA);
            Parametro(vetA, out var Soma, out var Media);

            Console.WriteLine($"A soma dos valores do Vetor é: {Soma}");
            Console.WriteLine($"A média dos valores do Vetor é: {Media}");

        }
        public static void Preencher(ref int[] vetA)
        {
            vetA[0] = 0;
            vetA[1] = 1;
            vetA[2] = 2;
            vetA[3] = 3;
            vetA[4] = 4;
            vetA[5] = 5;
            vetA[6] = 6;
            vetA[7] = 7;

        }
        public static void Parametro(int[] vetA, out int Soma, out int Media)
        {
            Soma = vetA.Sum();
            Media = Soma / vetA.Length;
        }
    }
}
