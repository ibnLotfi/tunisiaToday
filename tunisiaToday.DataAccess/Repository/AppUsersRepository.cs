using tunisiaToday.DataAccess.Data;
using tunisiaToday.DataAccess.Repository.IRepository;
using tunisiaToday.Models;

namespace tunisiaToday.DataAccess.Repository
{
    public class AppUsersRepository : Repository<AppUsers>, IAppUsersRepository
    {
        private readonly ApplicationDbContext _db;

        public AppUsersRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
