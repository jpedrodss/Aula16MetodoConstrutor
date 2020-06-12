using System;

namespace Aula16MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto celular = new Produto();

            Produto tenis = new Produto(588);
            System.Console.WriteLine(tenis.Codigo);            
            Produto carro = new Produto(549, "Peugeot", "carro vrum vrum", 1);
            System.Console.WriteLine($"\n{carro.Codigo}\n{carro.Nome}\n{carro.Descricao}\n{carro.Estoque}");
        }
    }
}
