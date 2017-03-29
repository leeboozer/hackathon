using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class CandidateResponse
    {
        public long CandidateResponseId { get; set; }
        public long? CandidateId { get; set; }
        public DateTime ResponseDate { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }
        public bool Preferred { get; set; }
        public long? OrderQuestionnaireId { get; set; }
        public int Ordinal { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual OrderQuestionnaire OrderQuestionnaire { get; set; }
    }
}
