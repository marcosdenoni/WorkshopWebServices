using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Controller de cadastro de livros em geral
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly ILogger<LivroController> _logger;

        private readonly DBContext _dBContext;

        public LivroController(ILogger<LivroController> logger, DBContext dBContext)
        {
            _logger = logger;
            _dBContext = dBContext;
        }

        /// <summary>
        /// Obtem todos os livrous ou do id especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Livro> Get(int? id)
        {
            if (id == null)
                return _dBContext.ListarLivros().ToArray();

            return _dBContext.ListarLivros().Where(l => l.Id == id).ToArray();
        }

        /// <summary>
        /// Remove um livro por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool Remover(int id) => _dBContext.RemoverLivro(id);

        /// <summary>
        /// Insere um novo livro
        /// </summary>
        /// <param name="livro"></param>
        /// <returns></returns>
        [HttpPost]
        public int Inserir(Livro livro) => _dBContext.Inserir(livro);
    }
}