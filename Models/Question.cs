using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Question
    {
        public Question()
        {
            QuestionAnswer = new HashSet<QuestionAnswer>();
        }

        public long QuestionId { get; set; }
        public long QuestionnaireId { get; set; }
        public int QuestionType { get; set; }
        public string QuestionText { get; set; }
        public bool Required { get; set; }
        public int Ordinal { get; set; }

        public virtual ICollection<QuestionAnswer> QuestionAnswer { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
    }
}
