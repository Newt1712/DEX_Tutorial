using AK.Core.Domains.Article;
using AK.Core.Domains.Category;
using AK.Core.Domains.Course;
using AK.Core.Domains.Video;
using AK.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Core.Responses
{
    public class HomeIndexRM
    {
        public HomeIndexRM() { }

        public HomeIndexRM(List<CategoryItem> categories,
           List<CourseItem> coursePros,List<CourseItem> courseFrees,
           List<ArticleItem> articles, List<ArticleItem> videos)
        {
            Categories = categories;
            CoursePros = coursePros;
            CourseFrees = courseFrees;
            Articles = articles;
            Videos = videos;
        }

        public List<CategoryItem> Categories { get; set; }
        public List<CourseItem> CoursePros { get; set; }
        public List<CourseItem> CourseFrees { get; set; }
        public List<ArticleItem> Articles { get; set; }
        public List<ArticleItem> Videos { get; set; }

    }
}
