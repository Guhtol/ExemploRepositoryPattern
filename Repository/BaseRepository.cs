using System;

namespace ExemploRepositoryPattern.Repository
{
    public class BaseRepository
    {
        public string _connectionString { get; }
        public BaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
                    
    }
}