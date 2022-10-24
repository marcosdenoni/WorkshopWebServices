using ServicoWCF.Data;
using ServicoWCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicoWCF
{
    /// <summary>
    /// Implementação do contrato do livro
    /// </summary>
    public class LivroService : ILivroService
    {
        private readonly DBContext _dBContext;
        public LivroService()
        {
            _dBContext = new DBContext();
        }

        /// <summary>
        /// Insere um novo livro
        /// </summary>
        /// <param name="livro"></param>
        /// <returns></returns>
        public int Inserir(Livro livro)
        {
            return _dBContext.Inserir(livro);
        }

        public Livro[] Obter(int? id)
        {
            if (id != null)
                return _dBContext.ListarLivros().Where(l => l.Id == id).ToArray();
            return _dBContext.ListarLivros().ToArray();
        }

        public bool Remover(int id)
        {
            return _dBContext.RemoverLivro(id);
        }
    }
}
