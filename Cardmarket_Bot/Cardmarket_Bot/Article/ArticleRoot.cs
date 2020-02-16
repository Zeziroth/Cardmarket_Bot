using Cardmarket_Bot.General;
using System.Collections.Generic;
using System.Linq;

namespace Cardmarket_Bot.Article
{
    public class ArticleRoot
    {
        public List<Article> article { get; set; }
        public List<Link2> links { get; set; }

        public List<Article> GetArticleByFilter(string langName = "", string condition = "", int isFoil = -1, int isFirstEd = -1)
        {
            List<Article> articles = new List<Article>();

            articles.AddRange(article.Where(a => (a.language.languageName == langName || langName == "")
            && (a.condition == condition || condition == "")
             && (a.isFoil == (isFoil > 0 ? true : false) || isFoil == -1)
             && (a.isFirstEd == (isFirstEd > 0 ? true : false) || isFirstEd == -1)));

            return articles;
        }
    }
}
