using System.Linq;
using tunisiaToday.DataAccess.Data;
using tunisiaToday.DataAccess.Repository.IRepository;
using tunisiaToday.Models;

namespace tunisiaToday.DataAccess.Repository
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        private readonly ApplicationDbContext _db;

        public ArticleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Article article)
        {
            var objFromDb = _db.Articles.FirstOrDefault(s => s.Id == article.Id);
            objFromDb.Title = article.Title;
            objFromDb.Text = article.Text;
        }
    }
}
