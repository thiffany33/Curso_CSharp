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
        //SEM USAR NENHUM TIPO DE FUNÇÃO
        public static void Executar()
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            Letras(frase);
            Numeros(frase);
            Caractere(frase);
        }
        public static void Letras(string frase)
        {
            int sumLetras = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a')
                {
                    sumLetras++;
                }
                if (frase[i] == 'b')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'c')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'd')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'e')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'f')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'g')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'h')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'i')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'j')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'k')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'l')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'm')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'n')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'o')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'p')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'q')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'r')
                {
                    sumLetras++;
                }
                else if (frase[i] == 's')
                {
                    sumLetras++;
                }
                else if (frase[i] == 't')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'u')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'v')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'w')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'x')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'y')
                {
                    sumLetras++;
                }
                else if (frase[i] == 'z')
                {
                    sumLetras++;
                }
            }
            Console.WriteLine($"a quantidade de letras da frase é: {sumLetras}");
        }
        public static void Numeros(string frase)
        {
            int sumNumeros = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == '0')
                {
                    sumNumeros++;
                }
                if (frase[i] == '1')
                {
                    sumNumeros++;
                }
                else if (frase[i] == '2')
                {
                    sumNumeros++;
                }
                else if (frase[i] == '3')
                {
                    sumNumeros++;
                }
                else if (frase[i] == '4')
                {
                    sumNumeros++;
                }
                else if (frase[i] == '5')
                {
                    sumNumeros++;
                }
                else if (frase[i] == '6')
                {
                    sumNumeros++;
                }
                else if (frase[i] == '7')
                {
                    sumNumeros++;
                }
                else if (frase[i] == '8')
                {
                    sumNumeros++;
                }
                else if (frase[i] == '9')
                {
                    sumNumeros++;
                }
            }
            Console.WriteLine($"a quantidade de números da frase é: {sumNumeros}");
        }
        public static void Caractere(string frase)
        {
            int sumCaractere = 0;
            
            Console.WriteLine($"a quantidade de caracteres especiais da frase é: {sumCaractere}");
        }
    }
}