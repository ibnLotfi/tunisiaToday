using System;

namespace tunisiaToday.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IArticleRepository Article { get; }


        void Save();
    }
}
