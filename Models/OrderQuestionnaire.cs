using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class OrderQuestionnaire
    {
        public OrderQuestionnaire()
        {
            CandidateResponse = new HashSet<CandidateResponse>();
        }

        public long OrderQuestionnaireId { get; set; }
        public long NpnOrderId { get; set; }
        public long? CandidateId { get; set; }
        public long? ClientId { get; set; }
        public int QuestionnaireType { get; set; }
        public string QuestionnaireName { get; set; }
        public string QuestionnaireTitle { get; set; }
        public string QuestionnaireInstructions { get; set; }
        public DateTime SubmittedDate { get; set; }

        public virtual ICollection<CandidateResponse> CandidateResponse { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual Client Client { get; set; }
        public virtual NpnOrder NpnOrder { get; set; }
    }
}
