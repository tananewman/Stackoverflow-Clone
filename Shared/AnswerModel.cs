using System;

namespace BlazorUiDemo.Shared
{
    public class AnswerModel
    {
        public string Uuid { get; set; }
        public string QuestionUuid { get; set; }
        public string Body { get; set; }
        public string OwnerId { get; set; }
        public int VoteCount { get; set; }
        public DateTime TimeStamp { get; set; }
        public UserModel User { get; set; }
    }
}
