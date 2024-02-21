using AK.Core.Domains.Chapter;
using AK.Core.Domains.Chat;
using AK.Core.Domains.Course;
using AK.Core.Domains.Lesson;
using AK.Core.Domains.Message;
using AK.Core.UtilityModel;

namespace AK.Core.Responses
{
    public class MessageRM
    {
        public MessageRM() { }

        public MessageRM(List<MessageItem> messages, ChatItem chat, long? totalLesson, string url, string token, UserInfoModel user)
        {
            Messages = messages;
            Chat = chat;
            User = user;
            Url = url;
            Token = token;
            TotalLesson = totalLesson.HasValue ? totalLesson.Value : 0;
        }

        public string Url { get; set; }
        public string Token { get; set; }
        public long TotalLesson { get; set; }
        public UserInfoModel User { get; set; }
        public ChatItem Chat { get; set; }
        public List<MessageItem> Messages { get; set; }
        public List<LessonItem> Lessons { get; set; }

    }
}
