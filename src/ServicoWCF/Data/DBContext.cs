using ServicoWCF.Model;
using System.Collections.Generic;
using System.Linq;

namespace ServicoWCF.Data
{
    /// <summary>
    /// Mock banco de dados
    /// </summary>
    public class DBContext
    {
        private static List<Livro> livros = new List<Livro>();

        static DBContext()
        {
            livros.Add(new Livro()
            {
                Id=1,
                Nome = "O Silmarillion",
                Genero = "Fantasia",
                Autor = "J.R.R. Tolkien"
            });
            livros.Add(new Livro()
            {
                Id = 2,
                Nome = "Os Filhos de Húrin",
                Genero = "Fantasia",
                Autor = "J.R.R. Tolkien"
            });
            livros.Add(new Livro()
            {
                Id = 3,
                Nome = "Beren e Lúthien",
                Genero = "Fantasia",
                Autor = "J.R.R. Tolkien"
            });
            livros.Add(new Livro()
            {
                Id = 4,
                Nome = "A Queda de Gondolin",
                Genero = "Fantasia",
                Autor = "J.R.R. Tolkien"
            });
            livros.Add(new Livro()
            {
                Id = 5,
                Nome = "Contos Inacabados",
                Genero = "Fantasia",
                Autor = "J.R.R. Tolkien"
            });
            livros.Add(new Livro()
            {
                Id = 6,
                Nome = "O Hobbit",
                Genero = "Fantasia",
                Autor = "J.R.R. Tolkien"
            });
            livros.Add(new Livro()
            {
                Id = 7,
                Nome = "O Senhor dos Anéis",
                Genero = "Fantasia",
                Autor = "J.R.R. Tolkien"
            });
        }

        /// <summary>
        /// Adiciona um livro
        /// </summary>
        /// <param name="livro"></param>
        /// <returns>id inserido</returns>
        public int Inserir(Livro livro)
        {
            var ultimoId = livros.Max(l => l.Id);
            livro.Id = ++ultimoId;
            livros.Add(livro);
            return ultimoId;
        }

        /// <summary>
        /// Lista os livros
        /// </summary>
        public List<Livro> ListarLivros() => livros;

        /// <summary>
        /// Remove um livro
        /// </summary>
        /// <param name="livro"></param>
        public void RemoverLivro(Livro livro) => livros.Remove(livro);

        /// <summary>
        /// Remove um livro por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>verdadeiro se removido</returns>
        public bool RemoverLivro(int id)
        {
            var livro = livros.FirstOrDefault(l => l.Id == id);
            if (livro == null)
                return false;

            RemoverLivro(livro);

            return true;
        }
    }
}
