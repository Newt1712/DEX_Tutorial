using AK.Core.Domains.Article;
using AK.Core.Domains.Chapter;
using AK.Core.Domains.Chat;
using AK.Core.Domains.Course;
using AK.Core.Domains.Lesson;

namespace AK.Core.Responses
{
    public class ArticleDetailRM
    {
        public ArticleDetailRM() { }

        public ArticleDetailRM(ArticleItem article)
        {
            Article = article;
        }
        public ArticleItem Article { get; set; }

    }
}
