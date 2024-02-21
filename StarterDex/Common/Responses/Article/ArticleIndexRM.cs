using AK.Core.Domains.Article;
using AK.Core.Domains.Chapter;
using AK.Core.Domains.Chat;
using AK.Core.Domains.Course;
using AK.Core.Domains.Lesson;

namespace AK.Core.Responses
{
    public class ArticleIndexRM
    {
        public ArticleIndexRM() { }

        public ArticleIndexRM(List<ArticleItem> articles)
        {
            Articles = articles;
        }
        public List<ArticleItem> Articles { get; set; }

    }
}
