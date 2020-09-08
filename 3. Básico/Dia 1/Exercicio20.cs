using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_1
{
    public class Exercicio20
    {
        //Faça um jogo de Pedra Papel Tesoura para dois jogadores jogarem simultaneamente escolhendo uma das opções se dois jogadores escolherem a mesma opção é empate.
        //Entretanto se forem escolhas diferentes, o ganhador e determinado da seguinte forma; 
        //a) Pedra ganha da tesoura, porque a pedra quebra a tesoura; 
        //b) Tesoura ganha do papel, porque a tesoura corta o papel; 
        //c) Papel ganha da pedra, porque o papel cobre a pedra.Randomize a jogada do computador e faça 3 botões representando as opções de escolha
        public static void Executar()
        {
            Console.WriteLine("Escolha sua opção:");
            Console.WriteLine("Digite 1 para pedra");
            Console.WriteLine("Digite 2 para papel");
            Console.WriteLine("Digite 3 para tesoura");
            var usuario = Convert.ToInt32(Console.ReadLine());


            Random random = new Random();
            var maquina = random.Next(1, 4);

            if (usuario == 1 && maquina == 2)
            {
                Console.WriteLine("Você perdeu!");
                Console.WriteLine("Você: Pedra - Computador: Papel");
            }
            else if (usuario == 2 && maquina == 3)
            {
                Console.WriteLine("Você perdeu!");
                Console.WriteLine("Você: Papel - Computador: Tesoura");
            }
            else if (usuario == 3 && maquina == 1)
            {
                Console.WriteLine("Você perdeu!");
                Console.WriteLine("Você: Tesoura - Computador: Pedra");
            }
            else if (usuario == 1 && maquina == 3)
            {
                Console.WriteLine("Você ganhou!!");
                Console.WriteLine("Você: Pedra - Computador: Tesoura");
            }
            else if (usuario == 2 && maquina == 1)
            {
                Console.WriteLine("Você ganhou!!");
                Console.WriteLine("Você: Papel - Computador: Pedra");
            }
            else if (usuario == 3 && maquina == 2)
            {
                Console.WriteLine("Você ganhou!!");
                Console.WriteLine("Você: Tesoura - Computador: Papel");
            }
            else if (usuario == maquina)
            {
                Console.WriteLine("Jogaram a mesma opção");
            }
            Console.ReadKey();

        }
    }
}
