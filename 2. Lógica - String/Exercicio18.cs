using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio18
    {
        //Crie um programa console que solicite um número e uma largura.
        //Então crie um triângulo da largura usando o número.Exemplo:
        //Digite um número: 6
        //Digite uma largura: 6 
        //666666 
        //66666 
        //6666 
        //666 
        //66
        //6
        public static void Executar()
        {
            Console.WriteLine("Digite o número:");
            int linha = Convert.ToInt32(Console.ReadLine());

            for (int i = linha; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(linha);

                }
                Console.WriteLine(" ");
            }
        }
    }
}
