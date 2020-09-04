using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio7
    {
        public static void Executar()
        {
            Quantidade();
        }
        //1. Faça um metodo que receba uma frase fornecida pelo usuário, calcule e mostre quantas letras a frase possui.Não considerar os espaços. 
        public static void Quantidade()
        {
            Console.WriteLine("Digite uma frase qualquer: ");
            string frase = Console.ReadLine();

            frase.Split(' ');

            Console.WriteLine($"a frase tem {frase.Length} letras");
        }
        //2. Faça um metodo que receba duas frases e as concatene. 
        public static void Concatene()
        {
            Console.WriteLine("Digite a primeira frase: ");
            string frase1 = Console.ReadLine();
            Console.WriteLine("Digite a segunda frase: ");
            string frase2 = Console.ReadLine();

            Console.WriteLine(frase1.Concat(frase2));
        }
        //3. Faça um sketch que receba uma frase e retorne a quantidade de consoantes e vogais que estão presentes na frase.
        public static void Vogais()
        {
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();

            frase.ToLower();

            int sumConsoant = 0;
            int sumVogal = 0;

            //OUTRO JEITO DE FAZER

            //var text = "Meu primeiro TEXTO".Replace(" ", "").ToLower().ToList();
            //var countV = text.Where(x => x == 'a' || x == 'e'
            //                        || x == 'i' || x == 'o'
            //                        || x == 'u').Count();
            //var countC = text.Where(x => x != 'a' && x != 'e'
            //                       && x != 'i' && x != 'o'
            //                       && x != 'u').Count();
            //
            //Console.WriteLine(countV);
            //Console.WriteLine(countC);
            //Console.WriteLine(countV + countC);
            //Console.ReadKey();


            // PARA VOGAIS
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a')
                {
                    sumVogal++; 
                }
                else if (frase[i] == 'e')
                {
                    sumVogal++;
                }
                else if (frase[i] == 'i')
                {
                    sumVogal++;
                }
                else if (frase[i] == 'o')
                {
                    sumVogal++;
                }
                else if (frase[i] == 'u')
                {
                    sumVogal++;
                }
            }
            // PARA CONSOANTES  
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'b')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'c')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'd')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'f')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'g')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'h')
                {
                    sumConsoant++;
                }
                else if(frase[i] == 'j')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'k')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'l')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'm')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'n')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'p')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'q')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'r')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 's')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 't')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'v')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'w')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'x')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'y')
                {
                    sumConsoant++;
                }
                else if (frase[i] == 'z')
                {
                    sumConsoant++;
                }
            }
            Console.WriteLine($"a quantidade de vogais é: {sumVogal}");
            Console.WriteLine($"a quantidade de consoantes é: {sumConsoant}");
        }
        //4. Faça um console para criptografar uma frase digitada pelo usuário. A criptografia consiste em alterar as vogais da frase pelo caractere especial *.
        public static void Criptografia()
        {
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();

            frase.ToUpper();
            for (int i = 0; i > frase.Length; i++)
            {
                if (frase[i] == 'a')
                {
                    frase = "*";
                }
                if (frase[i] == 'e')
                {
                    frase = "*";
                }
                if (frase[i] == 'i')
                {
                    frase = "*";
                }
                if (frase[i] == 'o')
                {
                    frase = "*";
                }
                if (frase[i] == 'u')
                {
                    frase = "*";
                }
            }
            Console.WriteLine(frase);
        }
    }
}
