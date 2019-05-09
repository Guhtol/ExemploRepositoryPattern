using System;
using ExemploRepositoryPattern.Repository;
using ExemploRepositoryPattern.Repository.Interface;

namespace ExemploRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {                        
            var composicao = new Composicao(new PessoaRepository("conexão"));

            composicao.Delet(new Pessoa());
            Console.Write("\n");
            composicao.Insert(new Pessoa());                                
            Console.ReadKey();
        }
    }
}
