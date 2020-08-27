using System;

namespace Revisão
{
    public class Exercicio2
    {
        //A revendedora de carros paga aos seus funcionários vendedores dois salários
        //mínimos fixos(considere R$ 1.000,00 o valor do salário mínimo), mais uma comissão fixa de
        //R$ 50,00 por carro vendido e mais 5% do valor das vendas.Faça um algoritmo que determine
        //o salário total de um vendedor dado a quantidade de carros vendidos e o valor total das
        //vendas.
        // O Código ta certo e a lógica também, a sintaxe não 
        public static void Executar()
        {
            Exercicio2.Dados(out string nome, out int qtd, out decimal valor);
            Console.WriteLine(Exercicio2.Calculo(nome, qtd, valor));
        }

        public static void Dados(out string nome, out int qtd, out decimal valor)
        {
            Console.WriteLine("Qual o nome do funcionário?");
            nome = Console.ReadLine();

            Console.WriteLine($"Qunatos carros o funcionário{nome}vendeu?");
            qtd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Qual o valor total das vendas do funcionário {nome} ?");
            valor = Convert.ToDecimal(Console.ReadLine());
        }
        public static string Calculo(string nome, int qtd, decimal valor)
        {
            decimal comissao = ((valor * 0.05m) + (qtd * 50));
            decimal total = (comissao + 2000);

            return ($"O funcionário {nome} vendeu {qtd} de carros e isso sua comissão foi de {comissao} e o seu salário foi de {total}");
        }
    }
}

          

