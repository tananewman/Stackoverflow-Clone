using System.Collections.Generic;
using BlazorUiDemo.Shared;

namespace BlazorUiDemo.Server.Repo
{
    public static class UserData
    {
        public static IList<UserModel> GetUsers()
        {
            return new List<UserModel>
            {
                new UserModel
                {
                    Uuid = "1",
                    Username = "Luke Skywalker",
                    QuestionCount = 5,
                    AnswerCount = 10,
                    CommentCount = 30,
                    UpvoteCount = 60,
                    DownvoteCount = 90,
                    ProfilePictureUrl = "https://www.gravatar.com/avatar/bb7337eab8ce49a31f5241b307e0bfac?s=32&d=identicon&r=PG"
                },
                new UserModel
                {
                    Uuid = "2",
                    Username = "Michael Scott",
                    QuestionCount = 2,
                    AnswerCount = 3,
                    ProfilePictureUrl = "https://www.gravatar.com/avatar/c9165fe2b07347f7c2a41dc81ab67f0b?s=32&d=identicon&r=PG"
                },
                new UserModel
                {
                    Uuid = "3",
                    Username = "Donovan Mitchell",
                    QuestionCount = 3,
                    AnswerCount = 12,
                    ProfilePictureUrl = "https://www.gravatar.com/avatar/1f2bbeebdbd3407e8ec41d1e59bede69?s=32&d=identicon&r=PG&f=1"
                },
                new UserModel
                {
                    Uuid = "4",
                    Username = "Buzz Lightyear",
                    QuestionCount = 4,
                    AnswerCount = 30,
                    ProfilePictureUrl = "https://www.gravatar.com/avatar/3da4d2cfbe47c22a892e190d6f1d4e2a?s=32&d=identicon&r=PG"
                }
            };
        }
    }
}
