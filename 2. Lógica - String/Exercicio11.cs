using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio11
    {
        //Crie um programa console que solicite um nome de arquivo.
        //Caso o arquivo tenha a extensão.txt ou .csv apresente um OK, caso contrário apresente para o usuário o erro Tipo de arquivo inválido.
        public static void Executar()
        {
            Console.WriteLine("Digite nome do seu arquivo: ");
            string nome = Console.ReadLine(); 

            if (nome == ".text" || nome == ".csv")
            {
                Console.WriteLine("Tipo de arquivo válido");
            }
            else
            {
                Console.WriteLine("Tipo do arquivo inválido");
            }
        }
    }
}
