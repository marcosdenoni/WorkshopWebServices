// See https://aka.ms/new-console-template for more information
using ClienteWebAPI;

Console.WriteLine("Hello, World!");


var client = new WebAPIClient();


var idInserido = client.Inserir(new Livro()
{
    Nome = "teste",
    Autor = "Marcos",
    Genero = "dev"
});


var removido = client.Remover(idInserido);

Console.ReadLine();