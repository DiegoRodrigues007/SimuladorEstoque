



using Estoque;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();

        Console.WriteLine("Entre com os dados do produto: ");

        Console.Write("Nome: ");
        produto.Nome = Console.ReadLine();

        Console.Write("Preço do produto: ");
        produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Quantidade no estoque: ");
        produto.Quantidade = int.Parse(Console.ReadLine());


        Console.WriteLine("");
        Console.WriteLine($"Dados do produto: {produto} ");

        Console.WriteLine("");
        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int quantidadeEstoque = int.Parse(Console.ReadLine());
        produto.AdicionarProdutoEstoque(quantidadeEstoque);
        Console.WriteLine($"Dados atualizados:{produto} ");

        Console.WriteLine("");
        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        int quantidadeRemovidaEstoque = int.Parse(Console.ReadLine());
        produto.RemoverProdutoEstoque(quantidadeRemovidaEstoque);
        Console.WriteLine($"Dados atualizados:{produto} ");
    }
}