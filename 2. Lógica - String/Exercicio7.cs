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
            Frases(); 
        }
        //1. Faça um metodo que receba uma frase fornecida pelo usuário, calcule e mostre quantas letras a frase possui.Não considerar os espaços. 
        public static void Letras()
        {
            Console.WriteLine("Digite uma frase qualquer: ");


        }
        //2. Faça um sketch que receba duas frases e as concatene. 
        public static void Frases()
        {
            Console.WriteLine("Digite a primeira frase: ");
            string frase1 = Console.ReadLine();
            Console.WriteLine("Digite a segunda frase: ");
            string frase2 = Console.ReadLine();

            Console.WriteLine($"juntando as duas frases temos: {frase1} {frase2}");

        }
        //3. Faça um sketch que receba uma frase e retorne a quantidade de consoantes e vogais que estão presentes na frase.
        public static void Vogais()
        {

        }
        //4. Faça um sketch para criptografar uma frase digitada pelo usuário. A criptografia consiste em alterar as vogais da frase pelo caractere especial *.
        public static void Criptografia()
        {

        }
    }   
}
