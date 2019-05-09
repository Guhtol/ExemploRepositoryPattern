using ExemploRepositoryPattern.Repository.Interface;

namespace ExemploRepositoryPattern
{
    public class Composicao
    {
        public IPessoaRepository _pessoaRepository { get; set; }     
        public Composicao(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public void Insert(Pessoa pessoa){
            _pessoaRepository.Insert(pessoa);
        }

        public void Delet(Pessoa pessoa){
            _pessoaRepository.Delet(pessoa);
        }
    }
}