using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_desconto
{
    class Program
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public produto(string nome, double preco)
            nome = nome;
 
            preco = preco;
            }
    public double precoFinal(int quantidade)
    {
        double precoFinal = precoFinal * quantidade;
        if (quantidade <= 10)
        {
            return precoFinal;
        }
        else if (quantidade <= 20)
        {
            return precoFinal * 0.9;
            else if (quantidade <= 50)
            {
                return precoFinal * 0.8;
            }
            else (return quantidade * 0.75;)
        }

    }
}       

        static void Main(string[] args)
        {
            Console.WriteLine("Incira o nome do produto:");
            string produto = Console.ReadLine();           
            Console.WriteLine("Incira o preço:");
            double preco = double.Parse(                Console.ReadLine()).                ("C2");
            Console.WriteLine("Incira a quantidade");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Confira os ítens solicitados:");
            Console.WriteLine($"{produto}, {preco} {quantidade} unidades");
                            double precoFinal = preco * quantidade;
                if (quantidade <= 10)
                {
                Console.WriteLine($"O preço final dos ítens é {precoFinal:C2}");
            }
else if( quantidade <= 20)
            {
                double desconto1 = precoFinal * 0.9;
                Console.WriteLine($"O preço final dos ítens, com 10% de desconto é {desconto1:C2}");
            }
                else if(quantidade <= 50)
                        {
                double desconto2 = precoFinal * 0.8;
                Console.WriteLine($"O preço final dos ítens, com 20% de desconto é de {desconto2:C2}");
            }
                else if(quantidade >= 51)
            {
                double desconto3 = precoFinal * 0.75;
                Console.WriteLine($"O preço final dos ítens é de {desconto3:C2}");
            }
                
        }
    }
}
