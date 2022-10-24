using ClienteWCF.LivroServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria o cliente (o mesmo é gerado automáticamente neste caso)
            using (var client = new LivroServiceClient())
            {
                var livros = client.Obter(null);

                Console.WriteLine($"{livros.Length} livros obtitos");

                var idInserido = client.Inserir(new Livro()
                {
                    Nome = "teste",
                    Autor = "Marcos",
                    Genero = "dev"
                });

                Console.WriteLine($"livro com o id {idInserido} inserido");

                livros = client.Obter(null);

                Console.WriteLine($"{livros.Length} livros obtitos");

                var removido = client.Remover(idInserido);

                Console.WriteLine($"Removido com sucesso? {removido}");

                livros = client.Obter(null);

                Console.WriteLine($"{livros.Length} livros obtitos");
            }
        }
    }
}
