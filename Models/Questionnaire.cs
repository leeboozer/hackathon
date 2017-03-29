using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Questionnaire
    {
        public Questionnaire()
        {
            Question = new HashSet<Question>();
        }

        public long QuestionnaireId { get; set; }
        public long? ClientId { get; set; }
        public int QuestionnaireType { get; set; }
        public string QuestionnaireName { get; set; }
        public string QuestionnaireTitle { get; set; }
        public string QuestionnaireInstructions { get; set; }
        public bool IsEnabled { get; set; }

        public virtual ICollection<Question> Question { get; set; }
        public virtual Client Client { get; set; }
    }
}
