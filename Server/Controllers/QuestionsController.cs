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
    [Route("questions")]
    public class QuestionsController : ControllerBase
    {
        // Fake test data
        // make static object
        private static IList<QuestionModel> questions = new List<QuestionModel>
        {
            new QuestionModel
            {
                Title = "Just who?",
                Uuid = "1",
                Body = "Who do you think you are?",
                Owner = UserData.GetUsers().Single(x => x.Uuid == "2"),
                AnswerCount = 4,
                CommentCount = 3,
                TimeStamp = DateTime.Now.AddYears(-7)
            },
            new QuestionModel
            {
                Title = "What",
                Uuid = "2",
                Body = "What gives you the right?",
                Owner = UserData.GetUsers().Single(x => x.Uuid == "1"),
                AnswerCount = 1,
                CommentCount = 1,
                TimeStamp = DateTime.Now.AddYears(-3)
            },
            new QuestionModel
            {
                Title = "Where",
                Uuid = "3",
                Body = "Where do you get off?",
                Owner = UserData.GetUsers().Single(x => x.Uuid == "4"),
                AnswerCount = 3,
                CommentCount = 4,
                TimeStamp = DateTime.Now.AddDays(-3)
            }
        };

        [HttpGet]
        [Route("{id}")]
        public QuestionModel Get(string id)
        {
            return questions.Where(q => q.Uuid == id).FirstOrDefault();
        }

        [HttpGet]
        [Route("")]
        public IList<QuestionModel> GetAllQuestions()
        {
            return questions;
        }

        [HttpPost]
        [Route("")]
        public QuestionModel Post([FromBody] QuestionModel question)
        {
            // logic and incrementing is bad here, and would be calling service layer
            question.Uuid = (questions.Count + 1).ToString();
            question.Owner = UserData.GetUsers().Single(x => x.Uuid == "1");
            question.TimeStamp = DateTime.Now;

            questions.Add(question);

            return question;
        }

        [HttpPut]
        [Route("{id}/upvote")]
        public int Upvote(string id)
        {
            var question = questions.Where(q => q.Uuid == id).First();  // obvs we would null check this irl
            return ++question.VoteCount;
        }

        [HttpPut]
        [Route("{id}/downvote")]
        public int Downvote(string id)
        {
            var question = questions.Where(q => q.Uuid == id).First();  // obvs we would null check this irl
            return --question.VoteCount;
        }
    }
}
