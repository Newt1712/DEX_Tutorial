using AK.Core.Constants;
using AK.Core.Domains.Chapter;
using AK.Core.Domains.Chat;
using AK.Core.Domains.Course;
using AK.Core.Domains.Lesson;

namespace AK.Core.Responses
{
    public class CourseIndexRM
    {
        public CourseIndexRM() { }

        public CourseIndexRM(List<CourseItem> courses, PagingInfo pageModel)
        {
            Courses = courses;
            PageModel = pageModel;
        }

        public PagingInfo PageModel { get; set; }
        public List<CourseItem> Courses { get; set; }

    }
}
