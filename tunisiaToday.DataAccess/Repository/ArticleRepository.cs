using System.Collections.Generic;
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

        public Article GetLastAlaUneArticle()
        {
            IEnumerable<Article> listFromDb = _db.Articles.Where(b => b.estUne == true).OrderByDescending(b => b.DatePublication);
            Article article = listFromDb.ToList().FirstOrDefault();

            return article;
        }

        public IEnumerable<Article> GetWhereCategoryId(int id)
        {
            IEnumerable<Article> listFromDb = _db.Articles.Where(b => b.CategoryId == id).OrderByDescending(b => b.DatePublication);
            return listFromDb;
        }

        public void Update(Article article)
        {
            var objFromDb = _db.Articles.FirstOrDefault(s => s.Id == article.Id);
            if(objFromDb != null)
            {

                if(article.ImageUrl != null)
                {
                    objFromDb.ImageUrl = article.ImageUrl;
                }

                objFromDb.Title = article.Title;
                objFromDb.Text = article.Text;
                objFromDb.Previsualisation = article.Previsualisation;
                objFromDb.DatePublication = article.DatePublication;
                objFromDb.Maj = article.Maj;
                objFromDb.CategoryId = article.CategoryId;
                objFromDb.estUne = article.estUne;
            }
            
            
        }

        
    }
}
