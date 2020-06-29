using tunisiaToday.DataAccess.Data;
using tunisiaToday.DataAccess.Repository.IRepository;

namespace tunisiaToday.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Article = new ArticleRepository(_db);
            AppUsers = new AppUsersRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public IArticleRepository Article { get; private set; }

        public IAppUsersRepository AppUsers { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
