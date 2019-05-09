using System;
using System.Collections.Generic;
using ExemploRepositoryPattern.Repository.Interface;

namespace ExemploRepositoryPattern.Repository
{
    public class PessoaRepository : BaseRepository,IPessoaRepository
    {
        public PessoaRepository(string connectionString):base(connectionString)
        {
            
        }        
        public void Delet(Pessoa obj)
        {
            Console.Write("Delet");
        }

        public void Edit(Pessoa obj)
        {
            Console.Write("Edit");
        }

        public Pessoa Get()
        {
            return new Pessoa();
        }

        public List<Pessoa> GetAll()
        {
            return new List<Pessoa>();
        }

        public void Insert(Pessoa obj)
        {
            Console.Write("Insert");
        }
    }
}