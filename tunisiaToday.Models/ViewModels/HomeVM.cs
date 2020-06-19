using System.Collections.Generic;

namespace tunisiaToday.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Article> Article_Int { get; set; }

        public IEnumerable<Article> Article_Sport { get; set; }

        public IEnumerable<Article> Article_Pol { get; set; }

        public IEnumerable<Article> Article_Eco { get; set; }

        public Article Article { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
