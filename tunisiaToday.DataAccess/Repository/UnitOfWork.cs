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
        }
        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
