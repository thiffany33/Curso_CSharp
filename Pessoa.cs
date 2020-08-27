using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    class Pessoa
    {
        //Exemplo Objeto
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Saldo { get; set; }

        public static void Executar()
        {
            Pessoa conta = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa: ");
            conta.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF da pessoa: ");
            conta.Cpf = Console.ReadLine();
            Console.WriteLine("Digite o saldo da pessoa: ");
            conta.Saldo = Convert.ToDouble(Console.ReadLine());

            conta.Mostrar();
        }
        private void Mostrar()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Cpf);
            Console.WriteLine(Saldo);
        }
    }
}
