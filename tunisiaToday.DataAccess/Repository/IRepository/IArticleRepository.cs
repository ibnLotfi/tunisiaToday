using tunisiaToday.Models;

namespace tunisiaToday.DataAccess.Repository.IRepository
{
    public interface IArticleRepository : IRepository<Article>
    {
        void Update(Article article);
    }
}
