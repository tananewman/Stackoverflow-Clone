using System.Collections.Generic;
using BlazorUiDemo.Shared;
using System;
using System.Linq;

namespace BlazorUiDemo.Server.Repo
{
    public static class AnswerData
    {
        public static IList<AnswerModel> GetAnswers()
        {
            return new List<AnswerModel>
            {
                new AnswerModel
                {
                    Uuid = "10",
                    QuestionUuid = "1",
                    Body = "The King of Jamaica",
                    OwnerId = "1",
                    TimeStamp = DateTime.Now.AddMonths(-3),
                    User = UserData.GetUsers().Single(x => x.Uuid == "1")
                },
                new AnswerModel
                {
                    Uuid = "20",
                    QuestionUuid = "1",
                    Body = "YourMom",
                    OwnerId = "3",
                    TimeStamp = DateTime.Now.AddYears(-7),
                    VoteCount = 1,
                    User = UserData.GetUsers().Single(x => x.Uuid == "3")
                },
                new AnswerModel
                {
                    Uuid = "15",
                    QuestionUuid = "1",
                    Body = "Running around leaving scars",
                    OwnerId = "4",
                    TimeStamp = DateTime.Now.AddDays(-3),
                    VoteCount = 1,
                    User = UserData.GetUsers().Single(x => x.Uuid == "4")
                },
                new AnswerModel
                {
                    Uuid = "30",
                    QuestionUuid = "2",
                    Body = "Your Mom gives me the right",
                    OwnerId = "1",
                    TimeStamp = DateTime.Now.AddDays(-7),
                    User = UserData.GetUsers().Single(x => x.Uuid == "1")
                },
                new AnswerModel
                {
                    Uuid = "40",
                    QuestionUuid = "3",
                    Body = "*censored*",
                    OwnerId = "2",
                    TimeStamp = DateTime.Now.AddYears(-1),
                    User = UserData.GetUsers().Single(x => x.Uuid == "2")
                }
            };
        }
    }
}
