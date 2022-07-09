using System;

namespace ExercicioClasseProduto
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p1;

            p1 = new Produto();
            
            Console.WriteLine("Digite o nome do produto: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: ");
            p1.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine(p1);

            //Adiciona no estoque
            Console.WriteLine("Atualizar estoque: \n");
            Console.WriteLine("Digite a quantidade adicional: ");
            int adicional = int.Parse(Console.ReadLine());

            p1.AdicionaProduto(adicional);

            Console.WriteLine(p1);


            //Remove do estoque
            Console.WriteLine("Atualizar estoque: \n");
            Console.WriteLine("Digite a quantidade removida: ");
            int removido = int.Parse(Console.ReadLine());

            p1.RemoverProdutos(removido);


            Console.WriteLine(p1);



        }
    }
}
