using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio16
    {
        //Crie um programa console que solicite uma frase.
        //a) Conte e apresente a quantidade de letras do alfabeto existentes.
        //b) Conte e apresente a quantidade de caracteres especiais.
        //c) Conte e apresente a quantidade de dígitos.
        public static void Executar()
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            Letras(frase);

        }
        public static void Letras(string frase)
        {
            int sumLetras = 0;
            int sumNumero = 0;
            int sumCaractere = 0;

            for (int i = 0; i < frase.Length; i++)
            {

                if (char.IsDigit(frase[i]))
                {
                    sumNumero++;
                }
                else if (char.IsLetter(frase[i]))
                {
                    sumLetras++;
                }
                else
                {
                    sumCaractere++;
                }
            }
            Console.WriteLine($"A quantidade de letras é: {sumLetras}, a quantidade de números é: {sumNumero} e a quantidade de caracteres, incluindo espaço é: {sumCaractere}");
        }
    }
}