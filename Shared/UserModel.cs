using System;

namespace BlazorUiDemo.Shared
{
    public class UserModel
    {
        public string Uuid { get; set; }
        public string Username { get; set; }
        public int QuestionCount { get; set; }
        public int AnswerCount { get; set; }
        public int CommentCount { get; set; }
        public int UpvoteCount { get; set; }
        public int DownvoteCount { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}

	// user_id varchar(36) NOT NULL,
    // tesla_domain_username varchar(255) NOT NULL,
    // question_count int NOT NULL DEFAULT 0,
    // answer_count int NOT NULL DEFAULT 0,
    // comment_count int NOT NULL DEFAULT 0,
    // upvote_count int NOT NULL DEFAULT 0,
    // downvote_count int NOT NULL DEFAULT 0,
    // CONSTRAINT users_tesla_domain_username_unique UNIQUE (tesla_domain_username),
	// CONSTRAINT users_pk PRIMARY KEY (user_id)
