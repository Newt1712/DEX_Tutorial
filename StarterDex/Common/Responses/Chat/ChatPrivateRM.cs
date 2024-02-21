using AK.Core.Domains.Chapter;
using AK.Core.Domains.Course;
using AK.Core.Domains.Lesson;
using AK.Core.Entities.DFModels;
using AK.Core.Enums;

namespace AK.Core.Responses
{
    public class CourseIndexUnregisteredRM
    {
        public CourseIndexUnregisteredRM() { }

        public CourseIndexUnregisteredRM(CourseItem course, int? totalLesson, List<LessonItem> lessons, List<ChapterItem> chapters, UserCourseMap userCourseMap)
        {
            Course = course;

            TotalLesson = totalLesson.HasValue ? totalLesson.Value : 0;
            Chapters = chapters;
            UserCourseMap = userCourseMap;
            if (userCourseMap == null || userCourseMap.Status != (int)(UserCourseEnum.Status.COMPLETE))
                Lessons = lessons.Select(s =>
                {
                    s.RemoveVideo();
                    return s;
                }).ToList();
            else
                Lessons = lessons;
        }

        public int TotalLesson { get; set; }
        public CourseItem Course { get; set; }
        public UserCourseMap UserCourseMap { get; set; }
        public List<LessonItem> Lessons { get; set; }
        public List<ChapterItem> Chapters { get; set; }

    }
}
