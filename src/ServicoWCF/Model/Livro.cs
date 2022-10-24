using System.Runtime.Serialization;

namespace ServicoWCF.Model
{
    [DataContract]
    public class Livro
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Autor { get; set; }

        [DataMember]
        public string Genero { get; set; }
    }
}
