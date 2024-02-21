using AK.Core.Domains.Chapter;
using AK.Core.Domains.Chat;
using AK.Core.Domains.Course;
using AK.Core.Domains.Lesson;

namespace AK.Core.Responses
{
    public class ChatPrivateRM
    {
        public ChatPrivateRM() { }

        public ChatPrivateRM(List<ChatItem> chats, long total, string token)
        {
            Chats = chats;
            Total = total;
            Token = token;
        }

        public long Total { get; set; }
        public string Token { get; set; }
        public List<ChatItem> Chats { get; set; }

    }
}
