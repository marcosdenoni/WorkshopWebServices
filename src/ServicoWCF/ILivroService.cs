using ServicoWCF.Model;
using System.ServiceModel;

namespace ServicoWCF
{
    /// <summary>
    /// Interface para expor os métodos via contrato
    /// </summary>
    [ServiceContract]
    public interface ILivroService
    {
        [OperationContract]
        Livro[] Obter(int? id);

        [OperationContract]
        int Inserir(Livro livro);


        [OperationContract]
        bool Remover(int id);
    }
}
