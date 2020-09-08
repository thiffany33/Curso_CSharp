using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._2._Lógica___String
{
    public class Exercicio17
    {
        //Crie um programa console que solicite um login e senha.
        //Depois de 3 tentativas erradas o usuários deve ser rejeitado
        public static void Executar()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite seu login:");
                string login = Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                string senha = Console.ReadLine();

                Console.Clear();
            }
            Console.WriteLine("Usuário Negado");
        }
    }
}
