using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_2
{
    public class Exercicio21
    {
        //Escreva uma aplicação console que permita o usuário digitar vogais.Se for uma vogal mostre “OK”; se não for uma vogal, mostre uma mensagem de erro.
        //O programa deve aceitar letras maiúsculas e minúsculas.O programa deve continuar até o usuário digitar ‘!’.
        public static void Executar()
        {
            int num = 1;

            Console.WriteLine("Digite volgais:");
            string vogal = Console.ReadLine();

            num = vogal.Length;

            vogal.ToLower();

            for (int i = 0; i < num; i++)
            {
                if (vogal[i] == 'a' || vogal[i] == 'e' || vogal[i] == 'i' || vogal[i] == 'o' || vogal[i] == 'u')
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("ERRO");
                }
                num++;

                Console.WriteLine("Para sair digite '!' ");

                Console.Clear();
                
                if (vogal[i] == '!')
                {
                    Console.WriteLine("Sair");
                }
            }
        }
    }
}
