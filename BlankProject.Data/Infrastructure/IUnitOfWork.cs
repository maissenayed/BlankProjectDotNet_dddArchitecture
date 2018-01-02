using System;

namespace BlankProject.Data.Infrastructure
{
    public interface IUnitOfWork :IDisposable
    {
        RepositoryBase<T> GetRepository<T>() where T : class;
        void Commit();
    }
}
