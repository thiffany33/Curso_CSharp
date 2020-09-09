using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Dia_3
{
    public class Exercicio26
    {
        //Crie um programa console chamado Comissao.
        //O método Main() deve chamar outros dois métodos.
        //O primeiro método deve perguntar ao vendedor o valor das vendas diárias e retornar o valor digitado.
        //O segundo método deverá calcular a comissão do vendedor baseada na tabela abaixo:
        //0 até 999 3% 
        //1000 até 2999 4% 
        //Acima de 3000 5%
        //Mostre a comissão do vendedor.

        public static void Executar()
        {
            Vendas();
        }
        public static void Vendas()
        {
            Console.WriteLine("Qual o valor das vendas diárias?");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Comissao(valor);
        }
        public static void Comissao(decimal valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor Inválido");
            }
            else if (valor > 0 && valor <= 999)
            {
                valor = (valor * 0.03m); 
            }
            else if (valor > 999 && valor <= 3000)
            {
                valor = (valor * 0.04m); 
            }
            else if (valor > 3000)
            {
                valor = (valor * 0.05m);
            }

            Console.WriteLine($"A comissão é de: {valor}");
        }
    }
}
