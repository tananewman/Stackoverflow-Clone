using BlazorUiDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlazorUiDemo.Server.Repo;

namespace BlazorUiDemo.Server.Controllers
{
    [ApiController]
    [Route("answers")]
    public class AnswersController : ControllerBase
    {
        private static IList<AnswerModel> answers = new List<AnswerModel>
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
                Body = "Michael Scott",
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
                Body = "No comment",
                OwnerId = "2",
                TimeStamp = DateTime.Now.AddYears(-1),
                User = UserData.GetUsers().Single(x => x.Uuid == "2")
            }
        };

        [HttpPost]
        [Route("{questionId}")]
        public AnswerModel PostAnswer([FromBody] AnswerModel answer, string questionId)
        {
            // would be calling service layer here irl
            answer.User = UserData.GetUsers().Single(x => x.Uuid == "1");
            answer.Uuid = Guid.NewGuid().ToString();
            answer.TimeStamp = DateTime.Now;
            answers.Add(answer);

            return answer;
        }

        [HttpGet]
        [Route("")]
        public IList<AnswerModel> GetAllAnswers()
        {
            return answers;
        }

        [HttpGet]
        [Route("{questionId}")]
        public IEnumerable<AnswerModel> Get(string questionId)
        {
            return answers.Where(a => a.QuestionUuid == questionId).ToList();
        }

        [HttpGet]
        [Route("{questionId}/top-answer")]
        public AnswerModel GetTopAnswer(string id)
        {
            // skip null check.
            var topAnswers = answers.Where(a => a.QuestionUuid == id).OrderByDescending(a => a.VoteCount).ToList();

            // we're only gonna pick a top answer if it has distinguished itself as the true cream of the crop
            return topAnswers.Count == 1 ? topAnswers.First() : null;
        }

        [HttpPut]
        [Route("{id}/upvote")]
        public int Upvote(string id)
        {
            var answer = answers.Where(a => a.Uuid == id).First();  // obvs we would null check this irl
            return ++answer.VoteCount;
        }

        [HttpPut]
        [Route("{id}/downvote")]
        public int Downvote(string id)
        {
            var answer = answers.Where(q => q.Uuid == id).First();  // obvs we would null check this irl
            return --answer.VoteCount;
        }
    }
}
