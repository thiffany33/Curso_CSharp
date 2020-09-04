using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._1._Lógica
{
    public class Exercicio1
    {
        //Enunciado do Exercício: 
        //Faça um sketch que calcule a média aritmética entre quatro
        //notas(a serem inseridas via Serial) de um aluno e mostre sua
        //situação, que pode ser aprovado, reprovado ou exame
        //(aprovado >= 7, reprovado< 5)
        public static decimal Executar()
        {
            Console.WriteLine("Digite as quatro notas do aluno: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal c = Convert.ToDecimal(Console.ReadLine());
            decimal d = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = ((a + b + c + d) / 4);

            if (resultado >= 7)
            {
                Console.WriteLine($"O aluno está aprovado com média: {resultado}");
            }
            else
            {
                Console.WriteLine($"O aluno está reprovado ocm média: {resultado}");
            }
            return resultado;
        }
    }

}
