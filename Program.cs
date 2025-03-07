using System.Dynamic;

namespace Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(500, "Lápis", 2.50);
            Produto produto2 = new Produto(250, "Paçoca", 10.50);
            Produto produto3 = new Produto(221, "Chá", 7.99);

            Console.WriteLine(produto1.GetDetailProduct());
            Console.WriteLine(produto2.GetDetailProduct());
            Console.WriteLine(produto3.GetDetailProduct());


            Retangulo retangulo = new Retangulo();
            retangulo.Altura = 20;
            retangulo.Largura = 20;

            Console.WriteLine(GetArea);
        }



    }
}
