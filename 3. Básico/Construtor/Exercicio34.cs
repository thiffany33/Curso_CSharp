using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão._3._Básico.Construtor
{
    public class Exercicio34
    {
        //Crie uma classe chamada Pizza.
        //Coloque os campos para o nome, por exemplo, peperoni, um inteiro para o diâmetro e double para o preço.
        //Inclua propriedades get e set para cada campo.
        //Crie uma classe chamada TestaPizza que instancia um objeto pizza e demonstra como usa os acessores get e set.

        public string Nome { get; set; }
        public int Diametro { get; set; }
        public double Preco { get; set; }

        

    }
    public class TestaPizza
    {
        public static Exercicio34 Pizza = new Exercicio34
        {
            Nome = "Peperoni",
            Diametro = 34,
            Preco = 29.90
        };
        public static void Executar()
        {
            Console.WriteLine(Pizza.Nome);
            Console.WriteLine(Pizza.Diametro);
            Console.WriteLine(Pizza.Preco);
        }

    }
}
