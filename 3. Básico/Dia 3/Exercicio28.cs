using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_3
{
    public class Exercicio28
    {
        //Crie uma aplicação console que compute os preços das mesas e que tenha quatro métodos: 
        //    • Um método para receber o numero de gavetas na mesa como entrada esse método retorna o numero de gavetas; OK
        //    • Um método para receber como entrada uma char e retornar o tipo de madeira: OK
        //        - m: para mogno
        //        - c: para carvalho
        //        - p: para pinheiro. 
        //    • Um método para receber o numero de gavetas e o tipo de madeira e calcular o custo da mesa baseada no seguinte: OK
        //        – Mesas de pinheiro custam 100 reais;
        //        – Mesas de carvalho custam 140 reais;
        //        – Todas as outras mesas de madeira custam 180 reais;
        //        – São adicionados 30 reais para cada gaveta;
        //        – Esse método deve retornar o custo total da mesa.
        //    • Um método para mostrar todos os detalhes e o preço final. OK
        public static void Executar()
        {
            var qtd = Numero();
            var tipo = Madeira();
            var total = Calculo(qtd, tipo);
            Detalhe(total, qtd, tipo);
        }
        public static int Numero()
        {
            Console.WriteLine("Digite a quantidade de gavetas: ");
            int qtd = Convert.ToInt32(Console.ReadLine());

            return qtd;
        }
        public static char Madeira()
        {
            Console.WriteLine("Qual o tipo de madeira: ");
            Console.WriteLine("Digite 'm' para mogno");
            Console.WriteLine("Digite 'c' para carvalho");
            Console.WriteLine("Digite 'p' para pinheiro");
            char tipo = Convert.ToChar(Console.ReadLine());

            return tipo;
        }
        public static int Calculo(int qtd, char tipo)
        {
            Console.Clear();

            int pinheiro = 100;
            int carvalho = 140;
            int outros = 180;
            int adicional = 30;

            int total = 0;
            if (tipo == 'm' || tipo == 'M')
            {
                total = outros + (qtd * adicional);
            }
            else if (tipo == 'p' || tipo == 'P')
            {
                total = pinheiro + (qtd * adicional); 
            }
            else if (tipo == 'c' || tipo == 'C')
            {
                total = carvalho + (qtd * adicional);
            }
            else
            {
                Console.WriteLine("Digito Inválido");

            }

            return total;
        }
        public static void Detalhe(int total, int qtd, char tipo)
        {
            if (tipo == 'm' || tipo == 'M')
            {
                Console.WriteLine($"Você pediu uma mesa de Mogno, com {qtd} gavetas e ficou um total de {total}");
            }
            else if (tipo == 'p' || tipo == 'P')
            {
                Console.WriteLine($"Você pediu uma mesa de Pinheiro, com {qtd} gavetas e ficou um total de {total}");
            }
            else if (tipo == 'c' || tipo == 'C')
            {
                Console.WriteLine($"Você pediu uma mesa de Carvalho, com {qtd} gavetas e ficou um total de {total}");
            }
                
        }

    }
}


