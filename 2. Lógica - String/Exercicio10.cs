using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio10
    {
        //Crie um programa console que solicite uma senha verifique se a senha tem mais de 8 caracteres e menos de 16. 
        //Apresente para o usuário se sua senha é valida.
        public static void Executar()
        {
            Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine(); 

            if (senha.Length > 8 && senha.Length < 16)
            {
                Console.WriteLine("Senha Válida");
            }
            else
            {
                Console.WriteLine("Senha Inválida");
            }
        }
    }
}
