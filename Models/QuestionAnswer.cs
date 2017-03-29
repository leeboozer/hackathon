using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class QuestionAnswer
    {
        public long QuestionAnswerId { get; set; }
        public long QuestionId { get; set; }
        public string AnswerText { get; set; }
        public bool Preferred { get; set; }

        public virtual Question Question { get; set; }
    }
}
