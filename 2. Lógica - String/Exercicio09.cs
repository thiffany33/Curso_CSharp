using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio09
    {
        //Crie um programa console que solicite um documento com apenas números.
        //a) Se o documento tiver 11 caracteres formate com uma máscara de CPF(000.000.000-00). 
        //b) Se o documento tiver 14 caracteres formate com uma máscara de CNPJ(00.000.000/0000-00). 
        //c) Se o documento não entrar em nenhum das duas condições apresente um erro para o usuário.
        public static void Executar()
        {
            Console.WriteLine("Digite o número do seu documento");
            string num = Console.ReadLine();
            
            if (num.Length == 11)
            {
                Console.WriteLine(num.Insert(3, ".").Insert(7, ".").Insert(11, "-"));
            }
            else if (num.Length == 14)
            {
                Console.WriteLine(num.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-"));
            }
            else
            {
                Console.WriteLine("Número Inválido");
            }
        }
    }
}
