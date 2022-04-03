﻿namespace Data
{
    public class QuestionData
    {
        public QuestionData() { }
        public QuestionData(SubjectData Subject, string Title, string Text, string Username)
        {
            this.Subject = Subject;
            this.Title = Title;
            this.Text = Text;
            this.Username = Username;
        }

        public int Id { get; set; }
        public SubjectData Subject { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Username { get; set; }
        public DateTime Date { get; set; }
        public int Upvote { get; set; }
        public int Downvote { get; set; }

        // Metoder
        public int GetScore()
        {
            return Upvote - Downvote;
        }

        public int GetTotalVotes()
        {
            return Upvote + Downvote;
        }
    }
}
