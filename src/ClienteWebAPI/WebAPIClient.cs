using RestSharp;

namespace ClienteWebAPI
{
    public class WebAPIClient
    {
        readonly RestClient _client;

        public WebAPIClient()
        {
            _client = new RestClient("https://localhost:7183/");
        }


        /// <summary>
        /// Obtem todos os livrous ou do id especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Livro[]? Get(int? id) => _client.GetJsonAsync<Livro[]>($"Livro?id={id}").Result;

        /// <summary>
        /// Remove um livro por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Remover(int id)
        {
            var request = new RestRequest($"Livro?id={id}", Method.Delete);
            var response = _client.Execute(request);
            return response.IsSuccessful && bool.Parse(response.Content);
        }

        /// <summary>
        /// Insere um novo livro
        /// </summary>
        /// <param name="livro"></param>
        /// <returns></returns>
        public int Inserir(Livro livro)
        {
            var request = new RestRequest($"Livro", Method.Post);
            request.AddJsonBody(livro);
            var response = _client.Execute(request);
            return response.IsSuccessful ? int.Parse(response.Content) : 0;
        }
    }
}
