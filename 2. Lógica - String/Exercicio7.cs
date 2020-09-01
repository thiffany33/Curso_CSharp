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
            Calculo();
        }
        //1. Faça um metodo que receba uma frase fornecida pelo usuário, calcule e mostre quantas letras a frase possui.Não considerar os espaços. 
        public static void Calculo()
        {
            Console.WriteLine("Digite uma frase qualquer: ");
            string frase = Console.ReadLine();

            string novo = frase.Trim();

            Console.WriteLine($"a frase tem {novo.Length} letras");
        }
        //2. Faça um metodo que receba duas frases e as concatene. 
        public static void Frases()
        {
            Console.WriteLine("Digite a primeira frase: ");
            string frase1 = Console.ReadLine();
            Console.WriteLine("Digite a segunda frase: ");
            string frase2 = Console.ReadLine();

            frase1.Concat(frase2);

            Console.WriteLine(frase1);
        }
        //3. Faça um sketch que receba uma frase e retorne a quantidade de consoantes e vogais que estão presentes na frase.
        public static void Vogais()
        {
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {

            }

            //printf("Digite uma frase:  "); cin.getline(frase, 500); for (int = 0; int < strlen(frase); i++)
            //{
            //    if (strchr(voga, tolower(frase[i])) > 0) { vogal = vogal + 1; }
            //    else if (strchr(consoant, tolower(frase[i])) > 0)
            //    {
            //        consosnate = consoante + 1;

        }
        //4. Faça um sketch para criptografar uma frase digitada pelo usuário. A criptografia consiste em alterar as vogais da frase pelo caractere especial *.
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
