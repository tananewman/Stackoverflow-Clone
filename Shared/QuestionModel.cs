using System;

namespace BlazorUiDemo.Shared
{
    public class QuestionModel
    {
        public string Title { get; set; }
        public string Uuid { get; set; }
        public string Body { get; set; }
        public UserModel Owner { get; set; }
        public int AnswerCount { get; set; }
        public int CommentCount { get; set; }
        public int VoteCount { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
