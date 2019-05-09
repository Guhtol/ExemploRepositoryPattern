using System.Collections.Generic;

namespace ExemploRepositoryPattern.Repository.Interface
{
    public interface IBaseRepository<T>
    {
        void Delet(T obj);
        void Edit(T obj);
        T Get();
        List<T> GetAll();
        void Insert(T obj);
    }
}